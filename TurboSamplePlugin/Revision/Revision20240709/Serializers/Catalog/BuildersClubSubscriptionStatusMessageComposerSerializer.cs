using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class BuildersClubSubscriptionStatusMessageComposerSerializer(int header)
    : AbstractSerializer<BuildersClubSubscriptionStatusMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        BuildersClubSubscriptionStatusMessageComposer message
    )
    {
        //
    }
}
