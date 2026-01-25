using Turbo.Primitives.Messages.Incoming.NewNavigator;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.NewNavigator;

internal class NewNavigatorInitMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new NewNavigatorInitMessage();
}
