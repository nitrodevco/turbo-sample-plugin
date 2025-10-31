using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Sound;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Sound;

internal class JukeboxPlayListFullMessageComposerSerializer(int header)
    : AbstractSerializer<JukeboxPlayListFullMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        JukeboxPlayListFullMessageComposer message
    )
    {
        //
    }
}
