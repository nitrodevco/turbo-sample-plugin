using Turbo.Primitives.Messages.Outgoing.Sound;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Sound;

internal class OfficialSongIdMessageComposerSerializer(int header)
    : AbstractSerializer<OfficialSongIdMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, OfficialSongIdMessageComposer message)
    {
        //
    }
}
