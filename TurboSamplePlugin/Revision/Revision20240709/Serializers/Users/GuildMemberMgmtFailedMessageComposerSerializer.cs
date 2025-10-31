using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

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
