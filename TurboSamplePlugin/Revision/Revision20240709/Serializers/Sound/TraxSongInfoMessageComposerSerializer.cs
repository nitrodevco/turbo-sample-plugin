using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Sound;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Sound;

internal class TraxSongInfoMessageComposerSerializer(int header)
    : AbstractSerializer<TraxSongInfoMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, TraxSongInfoMessageComposer message)
    {
        //
    }
}
