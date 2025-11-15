using Turbo.Primitives.Messages.Outgoing.Roomsettings;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Roomsettings;

internal class RoomSettingsErrorEventMessageComposerSerializer(int header)
    : AbstractSerializer<RoomSettingsErrorEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        RoomSettingsErrorEventMessageComposer message
    )
    {
        //
    }
}
