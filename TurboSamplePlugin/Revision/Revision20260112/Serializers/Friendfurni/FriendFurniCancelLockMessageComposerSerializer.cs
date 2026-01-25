using Turbo.Primitives.Messages.Outgoing.Friendfurni;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Friendfurni;

internal class FriendFurniCancelLockMessageComposerSerializer(int header)
    : AbstractSerializer<FriendFurniCancelLockMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        FriendFurniCancelLockMessageComposer message
    )
    {
        //
    }
}
