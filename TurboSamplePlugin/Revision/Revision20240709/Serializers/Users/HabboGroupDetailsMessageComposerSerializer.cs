using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class HabboGroupDetailsMessageComposerSerializer(int header)
    : AbstractSerializer<HabboGroupDetailsMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        HabboGroupDetailsMessageComposer message
    )
    {
        //
    }
}
