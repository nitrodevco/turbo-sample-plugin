using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class GuideSessionEndedMessageComposerSerializer(int header)
    : AbstractSerializer<GuideSessionEndedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GuideSessionEndedMessageComposer message
    )
    {
        //
    }
}
