using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class QuizDataMessageComposerSerializer(int header)
    : AbstractSerializer<QuizDataMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, QuizDataMessageComposer message)
    {
        //
    }
}
