using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class EmailStatusResultEventMessageComposerSerializer(int header)
    : AbstractSerializer<EmailStatusResultEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        EmailStatusResultEventMessageComposer message
    )
    {
        //
    }
}
