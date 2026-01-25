using Turbo.Primitives.Messages.Outgoing.Users;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Users;

internal class GuildMembershipUpdatedMessageComposerSerializer(int header)
    : AbstractSerializer<GuildMembershipUpdatedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GuildMembershipUpdatedMessageComposer message
    )
    {
        //
    }
}
