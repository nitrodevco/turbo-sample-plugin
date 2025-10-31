using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Quest;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Quest;

internal class QuestsMessageComposerSerializer(int header)
    : AbstractSerializer<QuestsMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, QuestsMessageComposer message)
    {
        //
    }
}
