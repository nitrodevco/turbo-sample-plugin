using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Poll;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Poll;

internal class QuestionAnsweredEventMessageComposerSerializer(int header)
    : AbstractSerializer<QuestionAnsweredEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        QuestionAnsweredEventMessageComposer message
    )
    {
        //
    }
}
