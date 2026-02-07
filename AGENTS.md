# Turbo Sample Plugin Agent Notes

This repository stays lightweight. Full AI governance policy lives in `../turbo-cloud`.

## Plugin-specific placement rules
- Keep plugin composition and service registration in `TurboSamplePlugin/TurboSamplePlugin.cs`.
- Keep startup orchestration in `TurboSamplePlugin/SamplePluginService.cs`.
- Add protocol changes under:
  - `TurboSamplePlugin/Revision/<revision>/Parsers/<Domain>/`
  - `TurboSamplePlugin/Revision/<revision>/Serializers/<Domain>/`
- Treat `TurboSamplePlugin/Revision/README.md` as the local source of truth for revision layout.
- Do not move or duplicate revision parsers/serializers into `turbo-cloud`.
- For handler/grain architecture decisions (for example extended profile flow), follow:
  - `../turbo-cloud/AGENTS.md`
  - `../turbo-cloud/CONTEXT.md`
- For task recipes and portable prompt contract, use `../turbo-cloud/AGENTS.md` as canonical.
- Keep `PacketHandlers` and `EventHandlers` focused on message/event flow.
- Keep database concerns in `TurboSamplePlugin/Database/`.

## Packet addition checklist (revision work)
When adding packet mappings in `TurboSamplePlugin/Revision/Revision20260112`:
1. Update `TurboSamplePlugin/Revision/Revision20260112/Headers.cs`:
   - add/update incoming `MessageEvent` id constants
   - add/update outgoing `MessageComposer` id constants
2. Add parser class under:
   - `TurboSamplePlugin/Revision/Revision20260112/Parsers/<Domain>/*MessageParser.cs`
3. Add serializer class under:
   - `TurboSamplePlugin/Revision/Revision20260112/Serializers/<Domain>/*MessageComposerSerializer.cs`
4. Register mappings in:
   - `TurboSamplePlugin/Revision/Revision20260112/Revision20260112.cs`
   - incoming: `Parsers` dictionary with `MessageEvent` key
   - outgoing: `Serializers` dictionary with composer type + `MessageComposer` id
5. Ensure the required `using` directives are present in `Revision20260112.cs` for new parser/serializer namespaces.

## Quality checks
```bash
dotnet build TurboSamplePlugin/TurboSamplePlugin.csproj -t:TurboSamplePluginFastCheck
dotnet build TurboSamplePlugin/TurboSamplePlugin.csproj -t:TurboSamplePluginQualityGate
```
