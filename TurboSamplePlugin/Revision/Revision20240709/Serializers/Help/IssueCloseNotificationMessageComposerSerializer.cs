using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class IssueCloseNotificationMessageComposerSerializer(int header)
    : AbstractSerializer<IssueCloseNotificationMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        IssueCloseNotificationMessageComposer message
    )
    {
        //
    }
}
