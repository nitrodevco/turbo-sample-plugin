using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.NewNavigator;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.NewNavigator.Snapshots;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.NewNavigator;

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
