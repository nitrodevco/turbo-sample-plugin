using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class CallForHelpReplyMessageComposerSerializer(int header)
    : AbstractSerializer<CallForHelpReplyMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, CallForHelpReplyMessageComposer message)
    {
        //
    }
}
