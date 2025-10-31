using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Friendfurni;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Friendfurni;

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
