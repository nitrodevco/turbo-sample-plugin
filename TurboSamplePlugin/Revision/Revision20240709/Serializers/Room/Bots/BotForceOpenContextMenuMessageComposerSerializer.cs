using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Bots;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Bots;

internal class BotForceOpenContextMenuMessageComposerSerializer(int header)
    : AbstractSerializer<BotForceOpenContextMenuMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        BotForceOpenContextMenuMessageComposer message
    )
    {
        //
    }
}
