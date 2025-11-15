using Turbo.Primitives.Messages.Outgoing.Nft;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Nft;

internal class UserNftChatStylesMessageComposerSerializer(int header)
    : AbstractSerializer<UserNftChatStylesMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        UserNftChatStylesMessageComposer message
    )
    {
        //
    }
}
