using Turbo.Primitives.Messages.Outgoing.Help;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Help;

internal class QuizDataMessageComposerSerializer(int header)
    : AbstractSerializer<QuizDataMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, QuizDataMessageComposer message)
    {
        //
    }
}
