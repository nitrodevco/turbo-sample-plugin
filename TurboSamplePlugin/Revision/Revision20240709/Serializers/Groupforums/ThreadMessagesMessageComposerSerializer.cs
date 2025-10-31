using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Groupforums;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Groupforums;

internal class ThreadMessagesMessageComposerSerializer(int header)
    : AbstractSerializer<ThreadMessagesMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ThreadMessagesMessageComposer message)
    {
        //
    }
}
