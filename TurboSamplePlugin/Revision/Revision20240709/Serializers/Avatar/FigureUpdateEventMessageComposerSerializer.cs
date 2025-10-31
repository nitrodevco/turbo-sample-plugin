using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Avatar;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Avatar;

internal class FigureUpdateEventMessageComposerSerializer(int header)
    : AbstractSerializer<FigureUpdateEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        FigureUpdateEventMessageComposer message
    )
    {
        //
    }
}
