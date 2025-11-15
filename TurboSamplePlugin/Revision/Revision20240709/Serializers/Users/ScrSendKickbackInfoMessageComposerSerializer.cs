using Turbo.Primitives.Messages.Outgoing.Users;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class ScrSendKickbackInfoMessageComposerSerializer(int header)
    : AbstractSerializer<ScrSendKickbackInfoMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ScrSendKickbackInfoMessageComposer message
    )
    {
        //
    }
}
