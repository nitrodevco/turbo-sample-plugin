using Turbo.Primitives.Messages.Incoming.Sound;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Sound;

internal class GetUserSongDisksMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetUserSongDisksMessage();
}
