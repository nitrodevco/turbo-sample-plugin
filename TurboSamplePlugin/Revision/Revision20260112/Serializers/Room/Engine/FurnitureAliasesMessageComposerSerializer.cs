using Turbo.Primitives.Messages.Outgoing.Room.Engine;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Room.Engine;

internal class FurnitureAliasesMessageComposerSerializer(int header)
    : AbstractSerializer<FurnitureAliasesMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, FurnitureAliasesMessageComposer message)
    {
        packet.WriteInteger(message.Aliases.Count);

        foreach (var (alias, original) in message.Aliases)
        {
            packet.WriteString(alias).WriteString(original);
        }
    }
}
