using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.NewNavigator;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.NewNavigator;

internal class NavigatorAddCollapsedCategoryMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new NavigatorAddCollapsedCategoryMessage { CategoryName = packet.PopString() };
}
