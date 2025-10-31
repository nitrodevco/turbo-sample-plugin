using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class GuideTicketCreationResultMessageComposerSerializer(int header)
    : AbstractSerializer<GuideTicketCreationResultMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GuideTicketCreationResultMessageComposer message
    )
    {
        //
    }
}
