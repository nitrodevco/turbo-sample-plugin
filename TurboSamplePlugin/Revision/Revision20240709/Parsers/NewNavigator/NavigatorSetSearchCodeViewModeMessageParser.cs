using Turbo.Contracts.Abstractions;
using Turbo.Contracts.Enums.Navigator;
using Turbo.Primitives.Messages.Incoming.NewNavigator;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.NewNavigator;

internal class NavigatorSetSearchCodeViewModeMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new NavigatorSetSearchCodeViewModeMessage
        {
            CategoryName = packet.PopString(),
            ViewMode = (NavigatorViewModeType)packet.PopInt(),
        };
}
