using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.FriendList;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList;

internal class MessengerInitMessageComposerSerializer(int header)
    : AbstractSerializer<MessengerInitMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, MessengerInitMessageComposer message)
    {
        //
    }
}
