# Contributing

## Versioning & releases

Every push to `main` triggers the release pipeline: build + test, then tag and
publish a NuGet package to the GitHub Packages feed
(`https://nuget.pkg.github.com/SimpleRealtyBits/index.json`).

Package version comes from `<Version>` in `fieldroutes-api-client.csproj`.
Unchanged versions are skipped on publish (`--skip-duplicate`), so only pushes
that bump the version produce a new release.

## Version bump hook

The repo ships a `prepare-commit-msg` hook (`.githooks/`) that auto-increments
the version in `fieldroutes-api-client.csproj` before you commit. Enable it
once per clone:

```sh
git config core.hooksPath .githooks
```

Bump type is chosen by a marker in the commit message:

| Commit message                  | Version change     |
| ------------------------------- | ------------------ |
| `fix: typo`                     | none               |
| `chore: bump [bump]`            | patch → `1.0.1`    |
| `feat: new endpoint [minor]`    | minor → `1.1.0`    |
| `breaking change [major]`       | major → `2.0.0`    |

The hook rewrites `<Version>` in the csproj and stages it, so the version bump
travels inside your own commit — no bot commits, no direct pushes to `main`
required. Merge commits are skipped automatically.

Without the marker, nothing changes — no accidental version churn.

## Release flow

1. Branch off `main`
2. Commit changes with the desired marker (`[bump]`, `[minor]`, `[major]`)
3. Open a PR to `main`
4. After merge, the pipeline tags `v<version>` and publishes the package
