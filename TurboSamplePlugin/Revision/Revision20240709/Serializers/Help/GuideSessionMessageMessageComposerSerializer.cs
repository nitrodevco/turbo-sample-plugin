using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class GuideSessionMessageMessageComposerSerializer(int header)
    : AbstractSerializer<GuideSessionMessageMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GuideSessionMessageMessageComposer message
    )
    {
        //
    }
}
