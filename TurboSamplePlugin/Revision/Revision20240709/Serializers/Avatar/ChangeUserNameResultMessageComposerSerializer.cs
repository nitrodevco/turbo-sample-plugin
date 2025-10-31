using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Avatar;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Avatar;

internal class ChangeUserNameResultMessageComposerSerializer(int header)
    : AbstractSerializer<ChangeUserNameResultMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ChangeUserNameResultMessageComposer message
    )
    {
        //
    }
}
