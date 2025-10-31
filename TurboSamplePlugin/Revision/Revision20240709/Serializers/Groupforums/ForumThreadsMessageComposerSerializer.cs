using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Groupforums;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Groupforums;

internal class ForumThreadsMessageComposerSerializer(int header)
    : AbstractSerializer<ForumThreadsMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ForumThreadsMessageComposer message)
    {
        //
    }
}
