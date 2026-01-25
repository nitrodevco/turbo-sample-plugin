using Turbo.Primitives.Messages.Outgoing.Moderation;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Moderation;

internal class IssueInfoMessageComposerSerializer(int header)
    : AbstractSerializer<IssueInfoMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, IssueInfoMessageComposer message)
    {
        //
    }
}
