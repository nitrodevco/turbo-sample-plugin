using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Engine;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine;

internal class FurnitureAliasesMessageComposerSerializer(int header)
    : AbstractSerializer<FurnitureAliasesMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, FurnitureAliasesMessageComposer message)
    {
        packet.WriteInteger(message.Aliases.Count);

        foreach (var (alias, original) in message.Aliases)
        {
            packet.WriteString(alias);
            packet.WriteString(original);
        }
    }
}
