using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class IgnoreResultMessageComposerSerializer(int header)
    : AbstractSerializer<IgnoreResultMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, IgnoreResultMessageComposer message)
    {
        //
    }
}
