using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Poll;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Poll;

internal class QuestionFinishedEventMessageComposerSerializer(int header)
    : AbstractSerializer<QuestionFinishedEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        QuestionFinishedEventMessageComposer message
    )
    {
        //
    }
}
