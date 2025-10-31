using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Moderation;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Moderation;

internal class IssueInfoMessageComposerSerializer(int header)
    : AbstractSerializer<IssueInfoMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, IssueInfoMessageComposer message)
    {
        //
    }
}
