using Turbo.Contracts.Abstractions;
using Turbo.Contracts.Enums.Navigator;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Navigator;

public class NavigatorSetSearchCodeViewModeParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new NavigatorSetSearchCodeViewModeMessage
        {
            CategoryName = packet.PopString(),
            ViewMode = (NavigatorResultsMode)packet.PopInt(),
        };
}
