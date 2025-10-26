using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.NewNavigator;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.NewNavigator.Snapshots;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.NewNavigator;

internal class NavigatorMetaDataMessageSerializer(int header)
    : AbstractSerializer<NavigatorMetaDataMessage>(header)
{
    protected override void Serialize(IServerPacket packet, NavigatorMetaDataMessage message)
    {
        packet.WriteInteger(message.TopLevelContexts.Count);

        foreach (var context in message.TopLevelContexts)
        {
            packet.WriteString(context.SearchCode);
            packet.WriteInteger(context.QuickLinks.Count);

            foreach (var quickLink in context.QuickLinks)
            {
                NavigatorQuickLinkSnapshotSerializer.Serialize(packet, quickLink);
            }
        }
    }
}
