using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Navigator;

internal class GetOfficialRoomsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new GetOfficialRoomsMessage { AdIndex = packet.PopInt() };
}
