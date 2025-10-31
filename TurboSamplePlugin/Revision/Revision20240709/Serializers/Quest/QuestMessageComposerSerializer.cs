using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Quest;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Quest;

internal class QuestMessageComposerSerializer(int header)
    : AbstractSerializer<QuestMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, QuestMessageComposer message)
    {
        //
    }
}
