using Turbo.Primitives.Messages.Outgoing.Room.Session;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Session;

internal class YouAreSpectatorMessageComposerSerializer(int header)
    : AbstractSerializer<YouAreSpectatorMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, YouAreSpectatorMessageComposer message)
    {
        packet.WriteInteger(message.RoomId);
    }
}
