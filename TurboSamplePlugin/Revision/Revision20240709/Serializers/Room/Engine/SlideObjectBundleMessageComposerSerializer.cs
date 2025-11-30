using Turbo.Primitives.Messages.Outgoing.Room.Engine;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine;

internal class SlideObjectBundleMessageComposerSerializer(int header)
    : AbstractSerializer<SlideObjectBundleMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        SlideObjectBundleMessageComposer message
    )
    {
        packet
            .WriteInteger(message.OldX)
            .WriteInteger(message.OldY)
            .WriteInteger(message.NewX)
            .WriteInteger(message.NewY)
            .WriteInteger(message.FloorHeights.Length);

        foreach (var (objectId, prev, next) in message.FloorHeights)
        {
            packet
                .WriteInteger((int)objectId)
                .WriteString(prev.ToString())
                .WriteString(next.ToString());
        }

        packet.WriteInteger(message.RollerItemId);

        // avatar int moveType, total, prev, next height single
    }
}
