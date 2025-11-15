using Turbo.Primitives.Messages.Outgoing.Catalog;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class BuildersClubSubscriptionStatusMessageComposerSerializer(int header)
    : AbstractSerializer<BuildersClubSubscriptionStatusMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        BuildersClubSubscriptionStatusMessageComposer message
    )
    {
        packet
            .WriteInteger(message.SecondsLeft)
            .WriteInteger(message.FurniLimit)
            .WriteInteger(message.MaxFurniLimit);

        if (message.SecondsLeftWithGrace.HasValue)
            packet.WriteInteger(message.SecondsLeftWithGrace.Value);
    }
}
