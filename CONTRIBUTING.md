# Contributing

If this is your first time in the plugin repo, run bootstrap:

PowerShell:

```powershell
pwsh -File scripts/bootstrap.ps1
```

bash/zsh:

```bash
sh scripts/bootstrap.sh
```

## Build and quality scope

| Command | Scope | Use when |
| --- | --- | --- |
| `dotnet build TurboSamplePlugin/TurboSamplePlugin.csproj` | Plugin only | Default contributor build |
| `dotnet build ../turbo-cloud/Turbo.Main/Turbo.Main.csproj` | Core only | Verify emulator-only changes |
| `dotnet build ../turbo-cloud/Turbo.Cloud.sln` | Full integrated workspace | One-window core+plugin workflow |

The plugin repo default quality/build contract is project-scoped to `TurboSamplePlugin/TurboSamplePlugin.csproj`.

### Fast check (pre-commit)

```bash
dotnet build TurboSamplePlugin/TurboSamplePlugin.csproj -t:TurboSamplePluginFastCheck
```

### Full gate (pre-push + CI)

```bash
dotnet build TurboSamplePlugin/TurboSamplePlugin.csproj -t:TurboSamplePluginQualityGate
```

## Integrated plugin workflow

PowerShell:

```powershell
pwsh -File scripts/dev-integrated.ps1
```

bash/zsh:

```bash
sh scripts/dev-integrated.sh
```

Build-only mode:
- PowerShell: `pwsh -File scripts/dev-integrated.ps1 -BuildOnly`
- bash/zsh: `sh scripts/dev-integrated.sh --build-only`

## Toolchain pinning

Pinned toolchain files:
- .NET SDK pin: `global.json`
- Local tools pin: `.config/dotnet-tools.json`

When bumping versions, include a passing `TurboSamplePluginQualityGate` run in the same change.

## Git hooks

Repository-managed hooks in `.githooks`:
- `pre-commit` -> staged-file `dotnet format ... style --verify-no-changes` + `TurboSamplePluginFastCheck`
- `pre-push` -> `TurboSamplePluginQualityGate`

Enable if needed:

```bash
git config --local core.hooksPath .githooks
```

## Local config and runtime linkage

Plugin DB/runtime local settings:
1. Keep `.env` local to this repo and set `PLUGIN_DEV_CONNECTION`.
2. Ensure `turbo-cloud/appsettings.Development.json` includes `Turbo:Plugin:DevPluginPaths`.

## Troubleshooting integrated builds

If integrated solution build fails due unrelated core/plugin state, isolate first:

```bash
dotnet build TurboSamplePlugin/TurboSamplePlugin.csproj
```
