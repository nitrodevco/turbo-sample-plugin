using Turbo.Primitives.Messages.Outgoing.Quest;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Quest;

internal class QuestCancelledMessageComposerSerializer(int header)
    : AbstractSerializer<QuestCancelledMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, QuestCancelledMessageComposer message)
    {
        //
    }
}
