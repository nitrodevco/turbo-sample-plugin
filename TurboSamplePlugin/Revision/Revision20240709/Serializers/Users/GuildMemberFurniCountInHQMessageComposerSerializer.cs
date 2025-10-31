using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class GuildMemberFurniCountInHQMessageComposerSerializer(int header)
    : AbstractSerializer<GuildMemberFurniCountInHQMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GuildMemberFurniCountInHQMessageComposer message
    )
    {
        //
    }
}
