# Turbo Sample Plugin

## 5-Minute Plugin Quickstart
1. Clone and enter this plugin repo.
2. Run plugin bootstrap once.
3. Update plugin DB connection in `.env`.
4. Run integrated core+plugin development flow.

Clone:

```bash
git clone <your-plugin-repo-url> turbo-sample-plugin
cd turbo-sample-plugin
```

Bootstrap (PowerShell):

```powershell
pwsh -File scripts/bootstrap.ps1
```

Bootstrap (bash/zsh):

```bash
sh scripts/bootstrap.sh
```

Set `PLUGIN_DEV_CONNECTION` in `.env`, then run integrated workflow:

PowerShell:

```powershell
pwsh -File scripts/dev-integrated.ps1
```

bash/zsh:

```bash
sh scripts/dev-integrated.sh
```

## What This Repo Is
This repository is a plugin project for the Turbo emulator ecosystem.
It is loaded by the emulator in the sibling `turbo-cloud` repository and is not a standalone host app.

## Required Folder Layout

```text
your-dev-folder/
  turbo-cloud/
  turbo-sample-plugin/
```

This sibling layout is required for project references and integrated scripts.

## Tooling Baseline
- .NET SDK 9.x (pinned via `global.json`)
- Git
- MySQL (or compatible database)

Check SDK:

```bash
dotnet --version
```

## Build Scope Matrix
| Command | Scope | Default? | Use when |
| --- | --- | --- | --- |
| `dotnet build TurboSamplePlugin/TurboSamplePlugin.csproj` | Plugin only | Yes | Normal plugin development |
| `dotnet build ../turbo-cloud/Turbo.Main/Turbo.Main.csproj` | Core only | No | Validating core build independently |
| `dotnet build ../turbo-cloud/Turbo.Cloud.sln` | Full integrated workspace | No | One-window emulator + plugin validation |

## Revision Protocol Source of Truth
For protocol parser/serializer placement and naming, use:
- `TurboSamplePlugin/Revision/README.md`

This file explicitly defines the cross-repo boundary:
- plugin repo owns revision parsers/serializers
- core repo owns runtime host/domain orchestration

For Boost-style AI task recipes and prompt contract, use:
- `../turbo-cloud/AGENTS.md` (canonical source)
- Local tool adapters:
  - `CLAUDE.md`
  - `CODEX.md`

## Quality Model (Two-Phase)
- Fast local commit check:
  - `dotnet build TurboSamplePlugin/TurboSamplePlugin.csproj -t:TurboSamplePluginFastCheck`
- Full quality gate (pre-push + CI):
  - `dotnet build TurboSamplePlugin/TurboSamplePlugin.csproj -t:TurboSamplePluginQualityGate`

Hooks are repository-managed in `.githooks`:
- `pre-commit` runs staged-file `dotnet format` style verification, then fast check.
- `pre-push` runs full quality gate.

## Integrated Core + Plugin Workflow
This repo exposes integrated helpers for one-window plugin development:

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

Equivalent integrated helpers also exist in `turbo-cloud/scripts/`.

## Local Plugin Configuration
Create `.env` from `.env.example` and set:

```env
PLUGIN_DEV_CONNECTION=server=127.0.0.1;user=root;password=password;database=turbo
```

## Optional: DB Migrations
From `TurboSamplePlugin.DesignTime`:

```bash
dotnet ef migrations add Init --project ../TurboSamplePlugin/TurboSamplePlugin.csproj --startup-project . --context SampleDbContext --output-dir ../TurboSamplePlugin/Migrations
```

## Troubleshooting
### `turbo-cloud` path not found
Symptoms:
- Build fails on missing references under `..\..\turbo-cloud\...`.
- Integrated scripts fail to locate `Turbo.Main.csproj`.

Fix:
- Ensure `turbo-cloud` is cloned as a sibling folder next to `turbo-sample-plugin`.

### Plugin is built but not loaded by emulator
Symptoms:
- `Turbo.Main` runs but plugin features are missing.

Fix:
- Ensure `turbo-cloud/appsettings.Development.json` contains `Turbo:Plugin:DevPluginPaths` pointing to this plugin output folder.

### Wrong or missing .NET SDK
Symptoms:
- Build errors about unsupported `net9.0`.

Fix:
- Install .NET SDK 9.x and re-run `dotnet --version`.

### Quality checks fail on formatting/line endings
Run:

```bash
dotnet tool restore
dotnet format TurboSamplePlugin/TurboSamplePlugin.csproj style --verify-no-changes
dotnet format TurboSamplePlugin/TurboSamplePlugin.csproj analyzers --verify-no-changes
dotnet build TurboSamplePlugin/TurboSamplePlugin.csproj -t:TurboSamplePluginQualityGate
```

If your checkout predates `.gitattributes` normalization, line endings may need a fresh checkout before running repo-wide format checks.

## Contributing
See `CONTRIBUTING.md` for build scope, quality policy, and integrated workflow commands.
