using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Moderation;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Moderation;

internal class IssuePickFailedMessageComposerSerializer(int header)
    : AbstractSerializer<IssuePickFailedMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, IssuePickFailedMessageComposer message)
    {
        //
    }
}
