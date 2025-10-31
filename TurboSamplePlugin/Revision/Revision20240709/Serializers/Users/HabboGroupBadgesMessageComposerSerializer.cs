using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class HabboGroupBadgesMessageComposerSerializer(int header)
    : AbstractSerializer<HabboGroupBadgesMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, HabboGroupBadgesMessageComposer message)
    {
        //
    }
}
