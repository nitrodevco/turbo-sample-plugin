using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Vault;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Vault;

internal class CreditVaultStatusMessageComposerSerializer(int header)
    : AbstractSerializer<CreditVaultStatusMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CreditVaultStatusMessageComposer message
    )
    {
        //
    }
}
