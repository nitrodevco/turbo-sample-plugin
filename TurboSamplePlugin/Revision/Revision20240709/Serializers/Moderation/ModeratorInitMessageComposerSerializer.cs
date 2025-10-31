using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Moderation;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Moderation;

internal class ModeratorInitMessageComposerSerializer(int header)
    : AbstractSerializer<ModeratorInitMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ModeratorInitMessageComposer message)
    {
        //
    }
}
