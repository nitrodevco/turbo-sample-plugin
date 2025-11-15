using Turbo.Primitives.Messages.Outgoing.Catalog;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class HabboClubOffersMessageComposerSerializer(int header)
    : AbstractSerializer<HabboClubOffersMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, HabboClubOffersMessageComposer message)
    {
        //
    }
}
