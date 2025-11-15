using Turbo.Primitives.Messages.Outgoing.Help;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class GuideSessionStartedMessageComposerSerializer(int header)
    : AbstractSerializer<GuideSessionStartedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GuideSessionStartedMessageComposer message
    )
    {
        //
    }
}
