using Turbo.Primitives.Messages.Incoming.Navigator;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Navigator;

internal class ForwardToSomeRoomMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new ForwardToSomeRoomMessage { ForwardData = packet.PopString() };
}
