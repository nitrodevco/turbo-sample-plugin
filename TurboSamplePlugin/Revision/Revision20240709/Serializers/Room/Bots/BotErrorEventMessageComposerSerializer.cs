using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Bots;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Bots;

internal class BotErrorEventMessageComposerSerializer(int header)
    : AbstractSerializer<BotErrorEventMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, BotErrorEventMessageComposer message)
    {
        //
    }
}
