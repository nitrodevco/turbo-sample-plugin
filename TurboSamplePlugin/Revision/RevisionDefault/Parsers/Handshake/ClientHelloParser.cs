using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Handshake;

namespace TurboSamplePlugin.Revision.RevisionDefault.Parsers.Handshake;

public class ClientHelloParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new ClientHelloMessage
        {
            Production = packet.PopString(),
            Platform = packet.PopString(),
            ClientPlatform = packet.PopInt(),
            DeviceCategory = packet.PopInt(),
        };
}
