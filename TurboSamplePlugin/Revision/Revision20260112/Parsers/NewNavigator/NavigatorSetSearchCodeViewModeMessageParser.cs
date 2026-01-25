using Turbo.Primitives.Messages.Incoming.NewNavigator;
using Turbo.Primitives.Navigator.Enums;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.NewNavigator;

internal class NavigatorSetSearchCodeViewModeMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new NavigatorSetSearchCodeViewModeMessage
        {
            CategoryName = packet.PopString(),
            ViewMode = (NavigatorViewModeType)packet.PopInt(),
        };
}
