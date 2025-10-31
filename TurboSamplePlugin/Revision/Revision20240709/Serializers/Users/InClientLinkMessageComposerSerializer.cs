using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class InClientLinkMessageComposerSerializer(int header)
    : AbstractSerializer<InClientLinkMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, InClientLinkMessageComposer message)
    {
        //
    }
}
