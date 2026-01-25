using Turbo.Primitives.Messages.Outgoing.Poll;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Poll;

internal class PollContentsEventMessageComposerSerializer(int header)
    : AbstractSerializer<PollContentsEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        PollContentsEventMessageComposer message
    )
    {
        //
    }
}
