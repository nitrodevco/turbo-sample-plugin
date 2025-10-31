using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Moderation;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Moderation;

internal class ModeratorMessageComposerSerializer(int header)
    : AbstractSerializer<ModeratorMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ModeratorMessageComposer message)
    {
        //
    }
}
