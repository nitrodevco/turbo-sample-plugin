using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Handshake;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.RevisionDefault.Parsers.Handshake;

internal class ClientHelloParser : IParser
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
