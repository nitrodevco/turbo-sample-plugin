using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Avatar;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Avatar;

internal class WardrobeMessageComposerSerializer(int header)
    : AbstractSerializer<WardrobeMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, WardrobeMessageComposer message)
    {
        //
    }
}
