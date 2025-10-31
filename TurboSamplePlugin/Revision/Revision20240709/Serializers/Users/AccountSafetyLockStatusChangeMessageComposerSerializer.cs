using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class AccountSafetyLockStatusChangeMessageComposerSerializer(int header)
    : AbstractSerializer<AccountSafetyLockStatusChangeMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        AccountSafetyLockStatusChangeMessageComposer message
    )
    {
        //
    }
}
