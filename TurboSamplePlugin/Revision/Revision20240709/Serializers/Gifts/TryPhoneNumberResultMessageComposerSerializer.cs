using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Gifts;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Gifts;

internal class TryPhoneNumberResultMessageComposerSerializer(int header)
    : AbstractSerializer<TryPhoneNumberResultMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        TryPhoneNumberResultMessageComposer message
    )
    {
        //
    }
}
