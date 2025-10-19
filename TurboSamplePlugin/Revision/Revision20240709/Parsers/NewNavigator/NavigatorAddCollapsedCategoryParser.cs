using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.NewNavigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.NewNavigator;

public class NavigatorAddCollapsedCategoryParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new NavigatorAddCollapsedCategoryMessage { CategoryName = packet.PopString() };
}
