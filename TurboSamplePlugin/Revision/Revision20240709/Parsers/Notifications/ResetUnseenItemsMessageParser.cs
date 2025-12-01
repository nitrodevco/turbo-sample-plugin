using Turbo.Primitives.Messages.Incoming.Notifications;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Notifications;

internal class ResetUnseenItemsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new ResetUnseenItemsMessage();
}
