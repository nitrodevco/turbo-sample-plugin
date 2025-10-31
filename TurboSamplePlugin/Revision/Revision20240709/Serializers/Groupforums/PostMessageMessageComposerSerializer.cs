using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Groupforums;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Groupforums;

internal class PostMessageMessageComposerSerializer(int header)
    : AbstractSerializer<PostMessageMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, PostMessageMessageComposer message)
    {
        //
    }
}
