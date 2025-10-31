using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Landingview;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Landingview;

internal class PromoArticlesMessageComposerSerializer(int header)
    : AbstractSerializer<PromoArticlesMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, PromoArticlesMessageComposer message)
    {
        //
    }
}
