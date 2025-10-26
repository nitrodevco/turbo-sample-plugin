using Turbo.Packets.Abstractions;
using Turbo.Primitives.Snapshots.NewNavigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.NewNavigator.Snapshots;

internal class NavigatorQuickLinkSnapshotSerializer
{
    public static void Serialize(IServerPacket packet, NavigatorQuickLinkSnapshot message)
    {
        packet.WriteInteger(message.Id);
        packet.WriteString(message.SearchCode);
        packet.WriteString(message.Filter);
        packet.WriteString(message.Localization);
    }
}
