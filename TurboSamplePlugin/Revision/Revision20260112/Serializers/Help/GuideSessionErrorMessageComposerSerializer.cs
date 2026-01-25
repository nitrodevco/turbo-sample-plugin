using Turbo.Primitives.Messages.Outgoing.Help;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Help;

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
