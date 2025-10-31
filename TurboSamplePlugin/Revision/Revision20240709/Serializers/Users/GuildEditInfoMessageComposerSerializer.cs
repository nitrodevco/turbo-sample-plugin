using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class GuildEditInfoMessageComposerSerializer(int header)
    : AbstractSerializer<GuildEditInfoMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, GuildEditInfoMessageComposer message)
    {
        //
    }
}
