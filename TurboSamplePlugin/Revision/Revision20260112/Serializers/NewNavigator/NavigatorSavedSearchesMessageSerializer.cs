using Turbo.Primitives.Messages.Outgoing.NewNavigator;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20260112.Serializers.NewNavigator.Data;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.NewNavigator;

internal class NavigatorSavedSearchesMessageSerializer(int header)
    : AbstractSerializer<NavigatorSavedSearchesMessage>(header)
{
    protected override void Serialize(IServerPacket packet, NavigatorSavedSearchesMessage message)
    {
        packet.WriteInteger(message.SavedSearches.Count);

        foreach (var savedSearch in message.SavedSearches)
        {
            NavigatorQuickLinkSnapshotSerializer.Serialize(packet, savedSearch);
        }
    }
}
