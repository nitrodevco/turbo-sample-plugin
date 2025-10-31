using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Handshake;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Handshake;

internal class IdentityAccountsEventMessageComposerSerializer(int header)
    : AbstractSerializer<IdentityAccountsEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        IdentityAccountsEventMessageComposer message
    )
    {
        //
    }
}
