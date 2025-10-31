using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Engine;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine;

internal class ObjectRemoveMultipleMessageComposerSerializer(int header)
    : AbstractSerializer<ObjectRemoveMultipleMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ObjectRemoveMultipleMessageComposer message
    )
    {
        //
    }
}
