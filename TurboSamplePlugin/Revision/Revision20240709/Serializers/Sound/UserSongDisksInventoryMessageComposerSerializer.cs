using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Sound;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Sound;

internal class UserSongDisksInventoryMessageComposerSerializer(int header)
    : AbstractSerializer<UserSongDisksInventoryMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        UserSongDisksInventoryMessageComposer message
    )
    {
        //
    }
}
