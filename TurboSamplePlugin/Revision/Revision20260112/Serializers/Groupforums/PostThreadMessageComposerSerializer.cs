using Turbo.Primitives.Messages.Outgoing.Groupforums;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Groupforums;

internal class PostThreadMessageComposerSerializer(int header)
    : AbstractSerializer<PostThreadMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, PostThreadMessageComposer message)
    {
        //
    }
}
