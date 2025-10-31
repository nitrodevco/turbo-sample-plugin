using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Quest;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Quest;

internal class QuestCancelledMessageComposerSerializer(int header)
    : AbstractSerializer<QuestCancelledMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, QuestCancelledMessageComposer message)
    {
        //
    }
}
