using Turbo.Primitives.Messages.Outgoing.Users;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class HandItemReceivedMessageComposerSerializer(int header)
    : AbstractSerializer<HandItemReceivedMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, HandItemReceivedMessageComposer message)
    {
        //
    }
}
