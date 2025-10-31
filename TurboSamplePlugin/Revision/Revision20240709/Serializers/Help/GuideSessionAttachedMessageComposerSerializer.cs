using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

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
