using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Campaign;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Campaign;

internal class OpenCampaignCalendarDoorAsStaffMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new OpenCampaignCalendarDoorAsStaffMessage();
}
