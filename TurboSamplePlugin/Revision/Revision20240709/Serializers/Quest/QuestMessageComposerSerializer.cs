using Turbo.Primitives.Messages.Outgoing.Quest;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Quest;

internal class QuestMessageComposerSerializer(int header)
    : AbstractSerializer<QuestMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, QuestMessageComposer message)
    {
        //
    }
}
