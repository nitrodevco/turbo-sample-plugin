using Turbo.Primitives.Messages.Outgoing.Users;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class HabboGroupJoinFailedMessageComposerSerializer(int header)
    : AbstractSerializer<HabboGroupJoinFailedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        HabboGroupJoinFailedMessageComposer message
    )
    {
        //
    }
}
