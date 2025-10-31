using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Nft;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Nft;

internal class UserNftWardrobeMessageComposerSerializer(int header)
    : AbstractSerializer<UserNftWardrobeMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, UserNftWardrobeMessageComposer message)
    {
        //
    }
}
