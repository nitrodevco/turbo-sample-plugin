using Turbo.Primitives.Messages.Outgoing.Navigator;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Navigator;

internal class OfficialRoomsMessageComposerSerializer(int header)
    : AbstractSerializer<OfficialRoomsMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, OfficialRoomsMessageComposer message)
    {
        //
    }
}
