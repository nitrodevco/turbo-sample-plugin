using Turbo.Primitives.Messages.Outgoing.Poll;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Poll;

internal class PollErrorEventMessageComposerSerializer(int header)
    : AbstractSerializer<PollErrorEventMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, PollErrorEventMessageComposer message)
    {
        //
    }
}
