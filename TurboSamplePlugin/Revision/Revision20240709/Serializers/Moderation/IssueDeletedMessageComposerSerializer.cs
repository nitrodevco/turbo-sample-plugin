using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Moderation;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Moderation;

internal class IssueDeletedMessageComposerSerializer(int header)
    : AbstractSerializer<IssueDeletedMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, IssueDeletedMessageComposer message)
    {
        //
    }
}
