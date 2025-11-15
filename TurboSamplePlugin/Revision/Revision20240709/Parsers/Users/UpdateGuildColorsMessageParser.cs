using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Users;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Users;

internal class UpdateGuildColorsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new UpdateGuildColorsMessage();
}
