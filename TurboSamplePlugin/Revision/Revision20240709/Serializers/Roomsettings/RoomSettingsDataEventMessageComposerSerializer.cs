using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Roomsettings;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Roomsettings;

internal class RoomSettingsDataEventMessageComposerSerializer(int header)
    : AbstractSerializer<RoomSettingsDataEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        RoomSettingsDataEventMessageComposer message
    )
    {
        //
    }
}
