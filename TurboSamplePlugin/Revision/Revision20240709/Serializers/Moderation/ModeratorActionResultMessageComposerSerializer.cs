using Turbo.Primitives.Messages.Outgoing.Moderation;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Moderation;

internal class ModeratorActionResultMessageComposerSerializer(int header)
    : AbstractSerializer<ModeratorActionResultMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ModeratorActionResultMessageComposer message
    )
    {
        //
    }
}
