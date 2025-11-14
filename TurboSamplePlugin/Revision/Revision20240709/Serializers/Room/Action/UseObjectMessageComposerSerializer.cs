using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Action;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Action;

internal class UseObjectMessageComposerSerializer(int header)
    : AbstractSerializer<UseObjectMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, UseObjectMessageComposer message)
    {
        packet.WriteInteger(message.UserId).WriteInteger(message.ItemType);
    }
}
