using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Action;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Action;

internal class ExpressionMessageComposerSerializer(int header)
    : AbstractSerializer<ExpressionMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ExpressionMessageComposer message)
    {
        //
    }
}
