using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Sound;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Sound;

internal class PlayListMessageComposerSerializer(int header)
    : AbstractSerializer<PlayListMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, PlayListMessageComposer message)
    {
        //
    }
}
