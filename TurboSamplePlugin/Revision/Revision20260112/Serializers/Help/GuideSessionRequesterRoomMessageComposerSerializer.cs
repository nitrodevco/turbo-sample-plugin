using Turbo.Primitives.Messages.Outgoing.Help;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Help;

internal class GuideSessionRequesterRoomMessageComposerSerializer(int header)
    : AbstractSerializer<GuideSessionRequesterRoomMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GuideSessionRequesterRoomMessageComposer message
    )
    {
        //
    }
}
