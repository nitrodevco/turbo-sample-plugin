using Turbo.Primitives.Messages.Outgoing.Help;
using Turbo.Primitives.Packets;

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
