using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Roomsettings;

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
