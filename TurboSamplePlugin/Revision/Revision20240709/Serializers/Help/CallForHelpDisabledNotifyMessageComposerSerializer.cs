using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

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
