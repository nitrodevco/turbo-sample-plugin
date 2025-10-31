using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

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
