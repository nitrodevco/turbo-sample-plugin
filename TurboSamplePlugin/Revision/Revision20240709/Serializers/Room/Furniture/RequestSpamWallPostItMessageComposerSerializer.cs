using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Furniture;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Furniture;

internal class RequestSpamWallPostItMessageComposerSerializer(int header)
    : AbstractSerializer<RequestSpamWallPostItMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        RequestSpamWallPostItMessageComposer message
    )
    {
        //
    }
}
