using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.NewNavigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.NewNavigator;

internal class NavigatorSearchResultBlocksMessageSerializer(int header)
    : AbstractSerializer<NavigatorSearchResultBlocksMessage>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        NavigatorSearchResultBlocksMessage message
    )
    {
        //
    }
}
