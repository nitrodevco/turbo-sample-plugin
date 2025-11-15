using Turbo.Primitives.Orleans.Snapshots.Navigator;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.NewNavigator.Data;

internal class NavigatorSearchResultBlockSerializer
{
    public static void Serialize(IServerPacket packet, NavigatorSearchResultBlockSnapshot message)
    {
        packet
            .WriteString(message.SearchCode)
            .WriteString(message.Text)
            .WriteInteger((int)message.ActionAllowed)
            .WriteBoolean(message.ForceClosed)
            .WriteInteger((int)message.ViewMode)
            .WriteInteger(message.SearchResults.Length);

        foreach (var result in message.SearchResults)
        {
            RoomSettingsSerializer.Serialize(packet, result);
        }
    }
}
