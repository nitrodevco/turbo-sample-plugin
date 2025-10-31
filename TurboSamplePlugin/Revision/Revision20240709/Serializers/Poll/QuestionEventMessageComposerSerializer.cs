using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Poll;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Poll;

internal class QuestionEventMessageComposerSerializer(int header)
    : AbstractSerializer<QuestionEventMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, QuestionEventMessageComposer message)
    {
        //
    }
}
