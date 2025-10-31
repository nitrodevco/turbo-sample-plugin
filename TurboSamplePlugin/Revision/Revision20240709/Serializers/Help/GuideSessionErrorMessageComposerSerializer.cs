using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class GuideSessionErrorMessageComposerSerializer(int header)
    : AbstractSerializer<GuideSessionErrorMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GuideSessionErrorMessageComposer message
    )
    {
        //
    }
}
