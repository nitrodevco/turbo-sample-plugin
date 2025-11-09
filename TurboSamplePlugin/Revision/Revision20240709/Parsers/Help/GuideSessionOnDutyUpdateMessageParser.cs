using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Help;

internal class GuideSessionOnDutyUpdateMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GuideSessionOnDutyUpdateMessage();
}
