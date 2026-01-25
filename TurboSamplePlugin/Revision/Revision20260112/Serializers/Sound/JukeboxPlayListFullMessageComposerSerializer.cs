using Turbo.Primitives.Messages.Outgoing.Sound;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Sound;

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
