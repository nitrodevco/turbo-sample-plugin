using Turbo.Primitives.Messages.Outgoing.Groupforums;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Groupforums;

internal class PostThreadMessageComposerSerializer(int header)
    : AbstractSerializer<PostThreadMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, PostThreadMessageComposer message)
    {
        //
    }
}
