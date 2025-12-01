using Turbo.Primitives.Messages.Incoming.Users;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Users;

public class ScrGetUserInfoMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new ScrGetUserInfoMessage { ProductName = packet.PopString() };
}
