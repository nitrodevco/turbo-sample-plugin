using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Roomsettings;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Roomsettings;

internal class RoomSettingsSavedEventMessageComposerSerializer(int header)
    : AbstractSerializer<RoomSettingsSavedEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        RoomSettingsSavedEventMessageComposer message
    )
    {
        //
    }
}
