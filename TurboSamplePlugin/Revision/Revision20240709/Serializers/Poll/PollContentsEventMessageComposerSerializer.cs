using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Poll;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Poll;

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
