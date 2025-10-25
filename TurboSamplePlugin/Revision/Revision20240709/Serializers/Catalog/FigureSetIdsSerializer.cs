using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

public class FigureSetIdsSerializer(int header) : AbstractSerializer<FigureSetIdsMessage>(header)
{
    protected override void Serialize(IServerPacket packet, FigureSetIdsMessage message)
    {
        packet.WriteInteger(0); //length

        packet.WriteInteger(0); //length
    }
}
