using Turbo.Primitives.Messages.Outgoing.Help;
using Turbo.Primitives.Packets;

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
