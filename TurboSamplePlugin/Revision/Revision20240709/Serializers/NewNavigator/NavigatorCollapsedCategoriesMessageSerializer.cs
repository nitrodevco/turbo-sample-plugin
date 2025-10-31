using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.NewNavigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.NewNavigator;

internal class NavigatorCollapsedCategoriesMessageSerializer(int header)
    : AbstractSerializer<NavigatorCollapsedCategoriesMessage>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        NavigatorCollapsedCategoriesMessage message
    )
    {
        packet.WriteInteger(message.CollapsedCategoryIds.Count);

        foreach (var categoryId in message.CollapsedCategoryIds)
        {
            packet.WriteString(categoryId);
        }
    }
}
