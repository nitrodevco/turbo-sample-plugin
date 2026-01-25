using Turbo.Primitives.Messages.Incoming.Roomdirectory;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Roomdirectory;

internal class RoomNetworkOpenConnectionMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new RoomNetworkOpenConnectionMessage();
}
