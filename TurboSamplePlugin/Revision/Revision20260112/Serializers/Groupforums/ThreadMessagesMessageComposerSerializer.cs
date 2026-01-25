using Turbo.Primitives.Messages.Outgoing.Groupforums;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Groupforums;

internal class ThreadMessagesMessageComposerSerializer(int header)
    : AbstractSerializer<ThreadMessagesMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ThreadMessagesMessageComposer message)
    {
        //
    }
}
