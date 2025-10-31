using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Session;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Session;

internal class FlatAccessibleMessageComposerSerializer(int header)
    : AbstractSerializer<FlatAccessibleMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, FlatAccessibleMessageComposer message)
    {
        //
    }
}
