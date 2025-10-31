using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class GuildMembersMessageComposerSerializer(int header)
    : AbstractSerializer<GuildMembersMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, GuildMembersMessageComposer message)
    {
        //
    }
}
