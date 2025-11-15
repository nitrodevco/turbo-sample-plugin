using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Gifts;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Gifts;

internal class ResetPhoneNumberStateMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new ResetPhoneNumberStateMessage();
}
