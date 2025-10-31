using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Session;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Session;

internal class CantConnectMessageComposerSerializer(int header)
    : AbstractSerializer<CantConnectMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, CantConnectMessageComposer message)
    {
        //
    }
}
