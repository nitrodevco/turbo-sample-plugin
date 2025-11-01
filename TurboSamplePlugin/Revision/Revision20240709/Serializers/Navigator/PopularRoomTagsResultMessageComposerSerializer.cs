using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class PopularRoomTagsResultMessageComposerSerializer(int header)
    : AbstractSerializer<PopularRoomTagsResultMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        PopularRoomTagsResultMessageComposer message
    )
    {
        //
    }
}
