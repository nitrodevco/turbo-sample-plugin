using Turbo.Primitives.Messages.Outgoing.Users;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class ChangeEmailResultEventMessageComposerSerializer(int header)
    : AbstractSerializer<ChangeEmailResultEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ChangeEmailResultEventMessageComposer message
    )
    {
        //
    }
}
