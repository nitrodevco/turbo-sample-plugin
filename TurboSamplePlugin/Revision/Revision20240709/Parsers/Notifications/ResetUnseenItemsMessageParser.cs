using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Notifications;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Notifications;

internal class ResetUnseenItemsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new ResetUnseenItemsMessage();
}
