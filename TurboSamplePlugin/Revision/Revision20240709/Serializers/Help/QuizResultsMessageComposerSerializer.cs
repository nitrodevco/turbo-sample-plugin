using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class QuizResultsMessageComposerSerializer(int header)
    : AbstractSerializer<QuizResultsMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, QuizResultsMessageComposer message)
    {
        //
    }
}
