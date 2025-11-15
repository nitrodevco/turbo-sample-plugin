using Turbo.Primitives.Messages.Outgoing.Moderation;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Moderation;

internal class ModeratorCautionEventMessageComposerSerializer(int header)
    : AbstractSerializer<ModeratorCautionEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ModeratorCautionEventMessageComposer message
    )
    {
        //
    }
}
