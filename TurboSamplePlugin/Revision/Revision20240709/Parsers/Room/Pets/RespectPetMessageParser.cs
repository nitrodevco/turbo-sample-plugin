using Turbo.Primitives.Messages.Incoming.Room.Pets;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Pets;

internal class RespectPetMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new RespectPetMessage();
}
