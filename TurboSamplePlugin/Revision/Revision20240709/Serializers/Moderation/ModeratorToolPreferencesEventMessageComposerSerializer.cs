using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Moderation;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Moderation;

internal class ModeratorToolPreferencesEventMessageComposerSerializer(int header)
    : AbstractSerializer<ModeratorToolPreferencesEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ModeratorToolPreferencesEventMessageComposer message
    )
    {
        //
    }
}
