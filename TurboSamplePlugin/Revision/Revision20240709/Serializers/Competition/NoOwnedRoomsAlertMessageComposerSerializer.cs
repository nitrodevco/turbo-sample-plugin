using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Competition;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Competition;

internal class NoOwnedRoomsAlertMessageComposerSerializer(int header)
    : AbstractSerializer<NoOwnedRoomsAlertMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        NoOwnedRoomsAlertMessageComposer message
    )
    {
        //
    }
}
