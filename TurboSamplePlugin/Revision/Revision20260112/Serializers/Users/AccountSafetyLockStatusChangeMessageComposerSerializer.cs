using Turbo.Primitives.Messages.Outgoing.Users;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Users;

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
