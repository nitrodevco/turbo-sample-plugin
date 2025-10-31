using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Gifts;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Gifts;

internal class TryVerificationCodeResultMessageComposerSerializer(int header)
    : AbstractSerializer<TryVerificationCodeResultMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        TryVerificationCodeResultMessageComposer message
    )
    {
        //
    }
}
