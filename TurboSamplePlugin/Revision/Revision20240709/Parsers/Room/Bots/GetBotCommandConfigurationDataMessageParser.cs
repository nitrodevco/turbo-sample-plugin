using Turbo.Primitives.Messages.Incoming.Room.Bots;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Bots;

internal class GetBotCommandConfigurationDataMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetBotCommandConfigurationDataMessage();
}
