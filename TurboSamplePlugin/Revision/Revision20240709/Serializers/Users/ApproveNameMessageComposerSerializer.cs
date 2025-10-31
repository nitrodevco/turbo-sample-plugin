using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class ApproveNameMessageComposerSerializer(int header)
    : AbstractSerializer<ApproveNameMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ApproveNameMessageComposer message)
    {
        //
    }
}
