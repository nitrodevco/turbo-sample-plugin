using Turbo.Primitives.Messages.Outgoing.Help;
using Turbo.Primitives.Packets;

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
