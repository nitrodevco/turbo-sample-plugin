using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class GuildEditFailedMessageComposerSerializer(int header)
    : AbstractSerializer<GuildEditFailedMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, GuildEditFailedMessageComposer message)
    {
        //
    }
}
