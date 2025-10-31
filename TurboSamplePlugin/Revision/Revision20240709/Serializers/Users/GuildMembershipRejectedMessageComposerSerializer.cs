using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class GuildMembershipRejectedMessageComposerSerializer(int header)
    : AbstractSerializer<GuildMembershipRejectedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GuildMembershipRejectedMessageComposer message
    )
    {
        //
    }
}
