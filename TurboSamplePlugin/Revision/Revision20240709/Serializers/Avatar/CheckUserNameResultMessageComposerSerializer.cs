using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Avatar;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Avatar;

internal class CheckUserNameResultMessageComposerSerializer(int header)
    : AbstractSerializer<CheckUserNameResultMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CheckUserNameResultMessageComposer message
    )
    {
        //
    }
}
