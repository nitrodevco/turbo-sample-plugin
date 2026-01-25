using Turbo.Primitives.Messages.Outgoing.Help;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Help;

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
