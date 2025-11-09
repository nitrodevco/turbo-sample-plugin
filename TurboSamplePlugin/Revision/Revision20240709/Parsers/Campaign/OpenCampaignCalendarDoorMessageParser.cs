using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Campaign;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Campaign;

internal class OpenCampaignCalendarDoorMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new OpenCampaignCalendarDoorMessage();
}
