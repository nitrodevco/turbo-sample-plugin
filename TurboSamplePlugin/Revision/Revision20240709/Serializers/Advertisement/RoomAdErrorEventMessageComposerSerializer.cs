using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Advertisement;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Advertisement;

internal class RoomAdErrorEventMessageComposerSerializer(int header)
    : AbstractSerializer<RoomAdErrorEventMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, RoomAdErrorEventMessageComposer message)
    {
        //
    }
}
