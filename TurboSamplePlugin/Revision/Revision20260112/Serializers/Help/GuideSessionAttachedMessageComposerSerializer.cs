using Turbo.Primitives.Messages.Outgoing.Help;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Help;

internal class GuideSessionAttachedMessageComposerSerializer(int header)
    : AbstractSerializer<GuideSessionAttachedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GuideSessionAttachedMessageComposer message
    )
    {
        //
    }
}
