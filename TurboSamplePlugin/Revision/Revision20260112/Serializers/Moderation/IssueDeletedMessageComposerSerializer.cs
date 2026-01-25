using Turbo.Primitives.Messages.Outgoing.Moderation;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Moderation;

internal class IssueDeletedMessageComposerSerializer(int header)
    : AbstractSerializer<IssueDeletedMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, IssueDeletedMessageComposer message)
    {
        //
    }
}
