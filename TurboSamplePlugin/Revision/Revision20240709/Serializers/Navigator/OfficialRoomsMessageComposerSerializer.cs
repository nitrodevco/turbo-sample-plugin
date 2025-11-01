using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class OfficialRoomsMessageComposerSerializer(int header)
    : AbstractSerializer<OfficialRoomsMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, OfficialRoomsMessageComposer message)
    {
        //
    }
}
