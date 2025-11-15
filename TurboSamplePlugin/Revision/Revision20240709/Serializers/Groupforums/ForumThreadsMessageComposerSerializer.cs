using Turbo.Primitives.Messages.Outgoing.Groupforums;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Groupforums;

internal class ForumThreadsMessageComposerSerializer(int header)
    : AbstractSerializer<ForumThreadsMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ForumThreadsMessageComposer message)
    {
        //
    }
}
