using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class CallForHelpPendingCallsMessageComposerSerializer(int header)
    : AbstractSerializer<CallForHelpPendingCallsMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CallForHelpPendingCallsMessageComposer message
    )
    {
        //
    }
}
