using Turbo.Primitives.Messages.Outgoing.Help;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class GuideTicketResolutionMessageComposerSerializer(int header)
    : AbstractSerializer<GuideTicketResolutionMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GuideTicketResolutionMessageComposer message
    )
    {
        //
    }
}
