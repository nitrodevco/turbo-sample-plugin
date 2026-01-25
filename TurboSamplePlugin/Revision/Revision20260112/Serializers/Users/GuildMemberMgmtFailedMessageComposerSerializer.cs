using Turbo.Primitives.Messages.Outgoing.Users;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Users;

internal class GuildMemberMgmtFailedMessageComposerSerializer(int header)
    : AbstractSerializer<GuildMemberMgmtFailedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GuildMemberMgmtFailedMessageComposer message
    )
    {
        //
    }
}
