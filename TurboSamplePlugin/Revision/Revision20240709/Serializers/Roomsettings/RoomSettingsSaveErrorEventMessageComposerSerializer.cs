using Turbo.Primitives.Messages.Outgoing.Roomsettings;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Roomsettings;

internal class RoomSettingsSaveErrorEventMessageComposerSerializer(int header)
    : AbstractSerializer<RoomSettingsSaveErrorEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        RoomSettingsSaveErrorEventMessageComposer message
    )
    {
        //
    }
}
