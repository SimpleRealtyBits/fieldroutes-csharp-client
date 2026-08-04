#!/usr/bin/env python3
"""Generate C# entity code (models, requests, search params, clients) from api.md.

Output: src/Entities/*.cs and src/Core/GeneratedFieldRoutesApi.cs (facade).
Run: python3 tools/generate.py
"""
import re
import os
import shutil
import sys

ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
DOC = os.path.join(ROOT, "api.md")
OUT_DIR = os.path.join(ROOT, "src", "Entities")
FACADE_PATH = os.path.join(ROOT, "src", "Core", "FieldRoutesApi.cs")

ENTITY_NAME_RE = re.compile(r"^##\s+(.+)$")
ENDPOINT_RE = re.compile(r"^###\s+`/([^/]+)/(.+?)`$")

SKIP_PARAM_NAMES = {"authenticationKey", "authenticationToken"}

def snake(name: str) -> str:
    """appointmentID -> appointment_id (roughly, for var naming only)."""
    return re.sub(r"(?<!^)(?=[A-Z])", "_", name).lower()

def pascal(name: str) -> str:
    return name[:1].upper() + name[1:]

def pfx(entity: str) -> str:
    """Prefixed class name for an entity, e.g. customer -> FieldRoutesCustomer."""
    return "FieldRoutes" + pascal(entity)

def plural(name: str) -> str:
    """Pluralized client name, e.g. Customer -> Customers."""
    return name + "s"

def cs_escape(text: str) -> str:
    return text.replace("\\", "\\\\").replace("\"", "\\\"").replace("`", "")

def cs_type(field_name: str, typ: str, desc: str, nullable: bool = True, model: bool = False):
    t = (typ or "").strip().lower()
    d = desc.lower()
    if model and "array" in d:
        # e.g. unitIDs "An array of unit IDs", targetPests "array of integers"
        return "int[]"
    if t == "integer" or t == "int":
        base = "int"
    elif t == "number":
        base = "decimal"
    elif t == "boolean" or t == "bool":
        base = "bool"
    elif t == "string":
        base = "string"
    elif t == "array":
        if (field_name.endswith("IDs") or field_name == "targetPests"
                or field_name == "spotOptions"
                or "array of integers" in desc.lower()
                or "array of spotids" in desc.lower()
                or "array of additional spotids" in desc.lower()
                or "additional spotids to" in desc.lower()):
            base = "int[]"
        else:
            base = "List<object>"
    elif t == "":
        base = "object"
    else:
        base = "object"
    if base == "string":
        return "string" if not nullable else "string?"
    return base + ("?" if nullable else "")

class Field:
    def __init__(self, name, typ, required, desc):
        self.name = name
        self.typ = typ
        self.required = (required or "").strip().lower() == "yes"
        self.desc = (desc or "").strip()

class Endpoint:
    def __init__(self, action):
        self.action = action
        self.params = []
        self.response = []

def parse_doc():
    entities = {}
    current = None
    current_ep = None
    mode = None  # "params" | "response" | None
    for line in open(DOC, encoding="utf-8"):
        line = line.rstrip("\n")
        m = ENTITY_NAME_RE.match(line)
        if m and not line.startswith("### ") and m.group(1).strip().lower() != "table of contents":
            current = m.group(1).strip()
            current_ep = None
            mode = None
            entities.setdefault(current, [])
            continue
        m = ENDPOINT_RE.match(line)
        if m:
            ent, action = m.group(1), m.group(2)
            if current is None or ent != current:
                # entity name may differ from endpoint prefix only by case
                if current is None:
                    current = ent
                    entities.setdefault(current, [])
            ep = Endpoint(action)
            entities[current].append(ep)
            current_ep = ep
            mode = None
            continue
        if line.strip() == "**Parameters**":
            mode = "params"
            continue
        if line.strip() == "**Response**":
            mode = "response"
            continue
        if line.startswith("| `") and current_ep is not None and mode:
            cells = [c.strip() for c in line.strip().strip("|").split("|")]
            name = cells[0].strip("` ")
            typ = cells[1].strip() if len(cells) > 1 else ""
            required = cells[2].strip() if len(cells) > 2 else ""
            desc = cells[3].strip() if len(cells) > 3 else ""
            if not name or not name[0].isalpha():
                continue  # garbage/malformed rows in the doc (e.g. "1", "2")
            if mode == "params":
                if name not in SKIP_PARAM_NAMES:
                    current_ep.params.append(Field(name, typ, required, desc))
            else:
                current_ep.response.append(Field(name, typ, False, desc))
        elif line.startswith("| ---") or line.startswith("|---"):
            pass
        elif line.startswith("|") and current_ep and mode:
            pass  # malformed row, ignore
    return entities

def render_comment(field, indent):
    """XML doc comment line for a field."""
    desc = cs_escape(field.desc)
    if not desc:
        return None
    return f"{indent}/// <summary>{desc}</summary>"

def render_model(name, fields):
    lines = [f"/// <summary>{name} record as returned by the FieldRoutes API.</summary>",
             f"public sealed class {name}", "{"]
    for f in fields:
        c = render_comment(f, "    ")
        if c:
            lines.append(c)
        lines.append(f"    public {cs_type(f.name, f.typ, f.desc, model=True)} {pascal(f.name)} {{ get; set; }}")
    lines.append("}")
    return "\n".join(lines)

def render_request(cls, fields):
    lines = [f"public sealed class {cls}", "{"]
    for f in fields:
        c = render_comment(f, "    ")
        if c:
            lines.append(c)
        lines.append(f"    public {cs_type(f.name, f.typ, f.desc)} {pascal(f.name)} {{ get; set; }}")
    lines.append("")
    lines.append("    internal Dictionary<string, object?> ToDictionary()")
    lines.append("    {")
    lines.append("        var d = new Dictionary<string, object?>();")
    for f in fields:
        pn = pascal(f.name)
        if f.required:
            lines.append(f'        if ({pn} is null) throw new ArgumentException("Required parameter {pn} is null.", nameof({pn}));')
        if f.typ.strip().lower() == "array":
            lines.append(f"        if ({pn} is not null) d[\"{f.name}\"] = {pn};")
        else:
            lines.append(f"        if ({pn} is not null) d[\"{f.name}\"] = {pn};")
    lines.append("        return d;")
    lines.append("    }")
    lines.append("}")
    return "\n".join(lines)

def render_search_params(name, fields):
    lines = [f"public sealed class {name}SearchParameters", "{"]
    for f in fields:
        if f.name == "includeData":
            continue
        c = render_comment(f, "    ")
        if c:
            lines.append(c)
        lines.append(f"    public {cs_type(f.name, f.typ, f.desc)} {pascal(f.name)} {{ get; set; }}")
    lines.append("")
    lines.append("    /// <summary>Fields supporting query objects, e.g. { \"operator\": \">\", \"value\": \"2016-01-01\" }.</summary>")
    lines.append("    public Dictionary<string, FilterValue> AdditionalFilters { get; } = new();")
    lines.append("")
    lines.append("    internal Dictionary<string, object?> ToDictionary(bool includeData)")
    lines.append("    {")
    lines.append("        var d = new Dictionary<string, object?>();")
    for f in fields:
        if f.name == "includeData":
            continue
        pn = pascal(f.name)
        lines.append(f"        if ({pn} is not null) d[\"{f.name}\"] = {pn};")
    lines.append("        foreach (var (k, v) in AdditionalFilters)")
    lines.append("            d[k] = v;")
    lines.append("        if (includeData) d[\"includeData\"] = 1;")
    lines.append("        return d;")
    lines.append("    }")
    lines.append("}")
    return "\n".join(lines)

def render_client(entity, eps):
    cls = plural(pascal(entity)) + "Client"
    lines = [f"public sealed class {cls}", "{",
             "    private readonly FieldRoutesCore _core;",
             f"    internal {cls}(FieldRoutesCore core) => _core = core;", ""]
    for ep in eps:
        action = ep.action
        if action == "[id]":
            params_cls = pfx(entity) + "GetParameters"
            if ep.params:
                lines.append(f"    public Task<{pfx(entity)}> GetAsync(int id, {params_cls}? parameters = null, CancellationToken ct = default)")
                lines.append(f"        => _core.PostAsync<{pfx(entity)}>(\"{entity}\", id.ToString(CultureInfo.InvariantCulture), parameters?.ToDictionary(), ct);")
            else:
                lines.append(f"    public Task<{pfx(entity)}> GetAsync(int id, CancellationToken ct = default)")
                lines.append(f"        => _core.PostAsync<{pfx(entity)}>(\"{entity}\", id.ToString(CultureInfo.InvariantCulture), null, ct);")
            lines.append("")
        elif action == "get":
            req_cls = pfx(entity) + "GetBulkParameters"
            ids_param = next((p for p in ep.params if p.name.endswith("IDs") and p.typ.strip().lower() == "array"), None)
            others = [p for p in ep.params if p is not ids_param]
            if others:
                lines.append(f"    public Task<List<{pfx(entity)}>> GetBulkAsync(IEnumerable<int> ids, {req_cls}? parameters = null, CancellationToken ct = default)")
                lines.append("    {")
                lines.append("        var d = new Dictionary<string, object?> { ")
                lines.append(f'            [{(repr(ids_param.name) if ids_param else "\"ids\"")}] = ids.ToList(),')
                lines.append("        };")
                lines.append("        if (parameters is not null)")
                lines.append("            foreach (var (k, v) in parameters.ToDictionary()) d[k] = v;")
                lines.append(f'        return _core.PostAsync<List<{pfx(entity)}>>("{entity}", "get", d, ct);')
                lines.append("    }")
            else:
                lines.append(f"    public Task<List<{pfx(entity)}>> GetBulkAsync(IEnumerable<int> ids, CancellationToken ct = default)")
                lines.append("    {")
                lines.append("        var d = new Dictionary<string, object?> {")
                lines.append(f'            [{(repr(ids_param.name) if ids_param else "\"ids\"")}] = ids.ToList(),')
                lines.append("        };")
                lines.append(f'        return _core.PostAsync<List<{pfx(entity)}>>("{entity}", "get", d, ct);')
                lines.append("    }")
            lines.append("")
        elif action == "search":
            lines.append(f"    public Task<SearchResponse<{pfx(entity)}>> SearchAsync({pfx(entity)}SearchParameters parameters, bool includeData = false, CancellationToken ct = default)")
            lines.append(f'        => _core.PostSearchAsync<{pfx(entity)}>("{entity}", parameters.ToDictionary(includeData), ct);')
            lines.append("")
        else:
            method = pascal(action)
            req_cls = f"{pfx(entity)}{method}Request"
            has_response = bool(ep.response)
            ret = f"{pfx(entity)}{method}Result" if has_response else "int"
            if ep.params:
                lines.append(f"    public Task<{ret}> {method}Async({req_cls} request, CancellationToken ct = default)")
                lines.append(f'        => _core.PostAsync<{ret}>("{entity}", "{action}", request.ToDictionary(), ct);')
            else:
                lines.append(f"    public Task<{ret}> {method}Async(CancellationToken ct = default)")
                lines.append(f'        => _core.PostAsync<{ret}>("{entity}", "{action}", null, ct);')
            lines.append("")
    lines.append("}")
    return "\n".join(lines)

def repr(s):
    return '"' + s.replace('"', '\\"') + '"'

def emit(folder, file_name, body):
    path = os.path.join(OUT_DIR, folder, file_name + ".cs")
    with open(path, "w", encoding="utf-8") as f:
        f.write(HEADER + body + "\n")
    print(f"wrote {path}")

def main():
    global HEADER
    entities = parse_doc()
    if os.path.isdir(OUT_DIR):
        shutil.rmtree(OUT_DIR)
    os.makedirs(OUT_DIR)
    for sub in ("Models", "Requests", "Search", "Results", "Clients"):
        os.makedirs(os.path.join(OUT_DIR, sub))
    HEADER = ("// <auto-generated>\n"
              "// Generated from api.md by tools/generate.py. Do not edit by hand.\n"
              "#nullable enable\n"
              "using System;\n"
              "using System.Collections.Generic;\n"
              "using System.Globalization;\n"
              "using System.Linq;\n"
              "using System.Text.Json;\n"
              "using System.Threading;\n"
              "using System.Threading.Tasks;\n"
              "using FieldRoutesApiClient.Core;\n"
              "\n"
              "namespace FieldRoutesApiClient.Entities;\n")

    for entity, eps in sorted(entities.items()):
        model_fields = None
        for ep in eps:
            if ep.response:
                model_fields = ep.response
                break
        if model_fields is None:
            print(f"WARN: {entity} has no response table", file=sys.stderr)
            model_fields = []

        p = pfx(entity)

        # model
        emit("Models", f"{p}", render_model(f"{p}", model_fields))
        # request classes for create/update/actions and get parameters
        for ep in eps:
            action = ep.action
            if action == "[id]" and ep.params:
                emit("Requests", f"{p}GetParameters", render_request(f"{p}GetParameters", ep.params))
            elif action == "get" and ep.params:
                ids_row = next((q for q in ep.params if q.name.endswith("IDs") and q.typ.strip().lower() == "array"), None)
                others = [q for q in ep.params if q is not ids_row]
                if others:
                    emit("Requests", f"{p}GetBulkParameters", render_request(f"{p}GetBulkParameters", others))
            elif action == "search" and ep.params:
                emit("Search", f"{p}SearchParameters", render_search_params(p, ep.params))
            elif action not in ("[id]", "get", "search"):
                if ep.params:
                    emit("Requests", f"{p}{pascal(action)}Request", render_request(f"{p}{pascal(action)}Request", ep.params))
                if ep.response:
                    emit("Results", f"{p}{pascal(action)}Result", render_model(f"{p}{pascal(action)}Result", ep.response))
        # client
        emit("Clients", f"{plural(pascal(entity))}Client", render_client(entity, eps))

    # facade
    fac = [HEADER.split("namespace ", 1)[0].rstrip(),  # auto-gen header + usings
           "using FieldRoutesApiClient.Entities;",
           "",
           "namespace FieldRoutesApiClient.Core;",
           "",
           "/// <summary>Typed facade over every FieldRoutes entity client. Register with AddFieldRoutesClient and inject.</summary>",
           "public sealed partial class FieldRoutesApi", "{"]
    fac.append("    private readonly Dictionary<string, object> _clients = new();")
    fac.append("")
    for entity in sorted(entities):
        cn = plural(pascal(entity))
        ct = cn + "Client"
        fac.append(f"    public {ct} {cn} => ({ct})(_clients.TryGetValue(nameof({cn}), out var c) ? c : _clients[nameof({cn})] = new {ct}(_core));")
    fac.append("}")
    with open(FACADE_PATH, "w", encoding="utf-8") as f:
        f.write("\n".join(fac) + "\n")
    print(f"wrote {FACADE_PATH}")
    print(f"total entities: {len(entities)}")

if __name__ == "__main__":
    main()
