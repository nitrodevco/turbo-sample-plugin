using Turbo.Primitives.Messages.Incoming.Navigator;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Navigator;

internal class PopularRoomsSearchMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new PopularRoomsSearchMessage { Query = packet.PopString(), AdIndex = packet.PopInt() };
}
