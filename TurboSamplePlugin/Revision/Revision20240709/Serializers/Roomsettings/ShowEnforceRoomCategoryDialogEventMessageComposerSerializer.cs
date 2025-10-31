using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Roomsettings;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Roomsettings;

internal class ShowEnforceRoomCategoryDialogEventMessageComposerSerializer(int header)
    : AbstractSerializer<ShowEnforceRoomCategoryDialogEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ShowEnforceRoomCategoryDialogEventMessageComposer message
    )
    {
        //
    }
}
