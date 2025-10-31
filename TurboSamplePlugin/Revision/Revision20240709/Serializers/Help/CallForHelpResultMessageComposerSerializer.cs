using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class CallForHelpResultMessageComposerSerializer(int header)
    : AbstractSerializer<CallForHelpResultMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CallForHelpResultMessageComposer message
    )
    {
        //
    }
}
