using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Quest;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Quest;

internal class QuestDailyMessageComposerSerializer(int header)
    : AbstractSerializer<QuestDailyMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, QuestDailyMessageComposer message)
    {
        //
    }
}
