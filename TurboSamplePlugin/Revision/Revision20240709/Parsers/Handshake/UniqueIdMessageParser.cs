using Turbo.Primitives.Messages.Incoming.Handshake;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Handshake;

internal class UniqueIdMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new UniqueIdMessage
        {
            MachineID = packet.PopString(),
            Fingerprint = packet.PopString(),
            FlashVersion = packet.PopString(),
        };
}
