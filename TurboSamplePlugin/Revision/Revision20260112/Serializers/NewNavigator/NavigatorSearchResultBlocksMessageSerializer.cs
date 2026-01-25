using Turbo.Primitives.Messages.Outgoing.NewNavigator;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20260112.Serializers.NewNavigator.Data;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.NewNavigator;

internal class NavigatorSearchResultBlocksMessageSerializer(int header)
    : AbstractSerializer<NavigatorSearchResultBlocksMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        NavigatorSearchResultBlocksMessageComposer message
    )
    {
        packet
            .WriteString(message.SearchCodeOriginal)
            .WriteString(message.FilteringData)
            .WriteInteger(message.Blocks.Length);

        foreach (var block in message.Blocks)
        {
            NavigatorSearchResultBlockSerializer.Serialize(packet, block);
        }
    }
}
