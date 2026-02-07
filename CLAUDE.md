# Claude Adapter (Turbo Sample Plugin)

This repository keeps plugin-specific rules locally and inherits full AI governance from `../turbo-cloud`.

## Required context load order
1. `AGENTS.md`
2. `TurboSamplePlugin/Revision/README.md`
3. `../turbo-cloud/AGENTS.md`
4. `../turbo-cloud/CONTEXT.md`

## Non-negotiable constraints
- Keep revision parser/serializer work under `TurboSamplePlugin/Revision/<revision>/**`.
- Update `Headers.cs`, parser/serializer classes, and `Revision<id>.cs` mappings together.
- Do not move protocol revision files into `turbo-cloud`.

## Validation commands
```bash
dotnet build TurboSamplePlugin/TurboSamplePlugin.csproj -t:TurboSamplePluginFastCheck
dotnet build TurboSamplePlugin/TurboSamplePlugin.csproj -t:TurboSamplePluginQualityGate
```
