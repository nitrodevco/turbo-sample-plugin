using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Nft;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Nft;

internal class UserNftWardrobeSelectionMessageComposerSerializer(int header)
    : AbstractSerializer<UserNftWardrobeSelectionMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        UserNftWardrobeSelectionMessageComposer message
    )
    {
        //
    }
}
