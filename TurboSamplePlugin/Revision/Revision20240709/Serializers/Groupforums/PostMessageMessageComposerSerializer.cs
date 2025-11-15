using Turbo.Primitives.Messages.Outgoing.Groupforums;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Groupforums;

internal class PostMessageMessageComposerSerializer(int header)
    : AbstractSerializer<PostMessageMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, PostMessageMessageComposer message)
    {
        //
    }
}
