using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Poll;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Poll;

internal class PollOfferEventMessageComposerSerializer(int header)
    : AbstractSerializer<PollOfferEventMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, PollOfferEventMessageComposer message)
    {
        //
    }
}
