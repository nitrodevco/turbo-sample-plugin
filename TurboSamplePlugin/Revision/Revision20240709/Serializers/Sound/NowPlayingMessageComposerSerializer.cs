using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Sound;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Sound;

internal class NowPlayingMessageComposerSerializer(int header)
    : AbstractSerializer<NowPlayingMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, NowPlayingMessageComposer message)
    {
        //
    }
}
