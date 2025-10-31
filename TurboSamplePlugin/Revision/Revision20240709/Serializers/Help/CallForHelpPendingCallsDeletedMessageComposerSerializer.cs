using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class CallForHelpPendingCallsDeletedMessageComposerSerializer(int header)
    : AbstractSerializer<CallForHelpPendingCallsDeletedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CallForHelpPendingCallsDeletedMessageComposer message
    )
    {
        //
    }
}
