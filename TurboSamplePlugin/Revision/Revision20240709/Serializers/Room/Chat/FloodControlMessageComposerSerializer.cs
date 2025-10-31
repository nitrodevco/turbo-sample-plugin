using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Chat;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Chat;

internal class FloodControlMessageComposerSerializer(int header)
    : AbstractSerializer<FloodControlMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, FloodControlMessageComposer message)
    {
        //
    }
}
