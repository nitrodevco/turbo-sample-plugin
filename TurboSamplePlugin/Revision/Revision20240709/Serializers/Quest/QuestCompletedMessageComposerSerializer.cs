using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Quest;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Quest;

internal class QuestCompletedMessageComposerSerializer(int header)
    : AbstractSerializer<QuestCompletedMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, QuestCompletedMessageComposer message)
    {
        //
    }
}
