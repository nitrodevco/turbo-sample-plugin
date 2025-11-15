using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Avatar;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Avatar;

internal class ChangeUserNameMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new ChangeUserNameMessage();
}
