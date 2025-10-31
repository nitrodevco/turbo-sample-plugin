using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Groupforums;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Groupforums;

internal class ForumDataMessageComposerSerializer(int header)
    : AbstractSerializer<ForumDataMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ForumDataMessageComposer message)
    {
        //
    }
}
