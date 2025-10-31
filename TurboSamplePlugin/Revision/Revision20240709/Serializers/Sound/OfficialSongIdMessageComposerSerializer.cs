using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Sound;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Sound;

internal class OfficialSongIdMessageComposerSerializer(int header)
    : AbstractSerializer<OfficialSongIdMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, OfficialSongIdMessageComposer message)
    {
        //
    }
}
