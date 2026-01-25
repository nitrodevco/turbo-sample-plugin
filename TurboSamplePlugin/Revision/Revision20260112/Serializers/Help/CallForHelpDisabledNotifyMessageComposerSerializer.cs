using Turbo.Primitives.Messages.Outgoing.Help;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Help;

internal class CallForHelpDisabledNotifyMessageComposerSerializer(int header)
    : AbstractSerializer<CallForHelpDisabledNotifyMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CallForHelpDisabledNotifyMessageComposer message
    )
    {
        //
    }
}
