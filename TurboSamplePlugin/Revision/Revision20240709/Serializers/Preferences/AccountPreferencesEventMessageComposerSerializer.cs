using Turbo.Primitives.Messages.Outgoing.Preferences;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Preferences;

internal class AccountPreferencesEventMessageComposerSerializer(int header)
    : AbstractSerializer<AccountPreferencesEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        AccountPreferencesEventMessageComposer message
    )
    {
        //
    }
}
