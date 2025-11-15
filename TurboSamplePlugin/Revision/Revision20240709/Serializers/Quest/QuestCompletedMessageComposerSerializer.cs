using Turbo.Primitives.Messages.Outgoing.Quest;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Quest;

internal class QuestCompletedMessageComposerSerializer(int header)
    : AbstractSerializer<QuestCompletedMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, QuestCompletedMessageComposer message)
    {
        //
    }
}
