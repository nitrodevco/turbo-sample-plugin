using Turbo.Primitives.Messages.Outgoing.Moderation;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Moderation;

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
