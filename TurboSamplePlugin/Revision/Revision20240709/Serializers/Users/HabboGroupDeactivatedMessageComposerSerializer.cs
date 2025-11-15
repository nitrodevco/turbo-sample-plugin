using Turbo.Primitives.Messages.Outgoing.Users;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class HabboGroupDeactivatedMessageComposerSerializer(int header)
    : AbstractSerializer<HabboGroupDeactivatedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        HabboGroupDeactivatedMessageComposer message
    )
    {
        //
    }
}
