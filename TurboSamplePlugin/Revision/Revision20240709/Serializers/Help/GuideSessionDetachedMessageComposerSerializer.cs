using Turbo.Primitives.Messages.Outgoing.Help;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class GuideSessionDetachedMessageComposerSerializer(int header)
    : AbstractSerializer<GuideSessionDetachedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GuideSessionDetachedMessageComposer message
    )
    {
        //
    }
}
