using Turbo.Primitives.Messages.Outgoing.Friendfurni;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Friendfurni;

internal class FriendFurniStartConfirmationMessageComposerSerializer(int header)
    : AbstractSerializer<FriendFurniStartConfirmationMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        FriendFurniStartConfirmationMessageComposer message
    )
    {
        //
    }
}
