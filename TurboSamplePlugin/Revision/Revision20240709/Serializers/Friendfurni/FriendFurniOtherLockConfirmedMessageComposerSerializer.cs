using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Friendfurni;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Friendfurni;

internal class FriendFurniOtherLockConfirmedMessageComposerSerializer(int header)
    : AbstractSerializer<FriendFurniOtherLockConfirmedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        FriendFurniOtherLockConfirmedMessageComposer message
    )
    {
        //
    }
}
