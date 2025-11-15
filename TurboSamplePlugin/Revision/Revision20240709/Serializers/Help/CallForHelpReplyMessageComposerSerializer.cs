using Turbo.Primitives.Messages.Outgoing.Help;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class CallForHelpReplyMessageComposerSerializer(int header)
    : AbstractSerializer<CallForHelpReplyMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, CallForHelpReplyMessageComposer message)
    {
        //
    }
}
