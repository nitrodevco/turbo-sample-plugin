using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Nux;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Nux;

internal class SelectInitialRoomEventMessageComposerSerializer(int header)
    : AbstractSerializer<SelectInitialRoomEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        SelectInitialRoomEventMessageComposer message
    )
    {
        //
    }
}
