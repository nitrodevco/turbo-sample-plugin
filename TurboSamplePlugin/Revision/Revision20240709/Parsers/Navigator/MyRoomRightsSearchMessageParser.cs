using Turbo.Primitives.Messages.Incoming.Navigator;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Navigator;

internal class MyRoomRightsSearchMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new MyRoomRightsSearchMessage();
}
