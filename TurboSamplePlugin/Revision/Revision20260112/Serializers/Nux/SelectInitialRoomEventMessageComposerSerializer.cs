using Turbo.Primitives.Messages.Outgoing.Nux;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Nux;

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
