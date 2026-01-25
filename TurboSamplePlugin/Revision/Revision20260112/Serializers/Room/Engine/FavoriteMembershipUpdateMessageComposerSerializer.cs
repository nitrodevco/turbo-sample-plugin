using Turbo.Primitives.Messages.Outgoing.Room.Engine;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Room.Engine;

internal class FavoriteMembershipUpdateMessageComposerSerializer(int header)
    : AbstractSerializer<FavoriteMembershipUpdateMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        FavoriteMembershipUpdateMessageComposer message
    )
    {
        //
    }
}
