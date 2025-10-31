using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class SnowWarGameTokensMessageMessageComposerSerializer(int header)
    : AbstractSerializer<SnowWarGameTokensMessageMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        SnowWarGameTokensMessageMessageComposer message
    )
    {
        //
    }
}
