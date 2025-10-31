using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class GuildMembershipsMessageComposerSerializer(int header)
    : AbstractSerializer<GuildMembershipsMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, GuildMembershipsMessageComposer message)
    {
        //
    }
}
