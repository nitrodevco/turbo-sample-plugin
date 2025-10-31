using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Hotlooks;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Hotlooks;

internal class HotLooksMessageComposerSerializer(int header)
    : AbstractSerializer<HotLooksMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, HotLooksMessageComposer message)
    {
        //
    }
}
