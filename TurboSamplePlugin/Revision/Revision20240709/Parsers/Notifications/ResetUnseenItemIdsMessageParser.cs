using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Notifications;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Notifications;

internal class ResetUnseenItemIdsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new ResetUnseenItemIdsMessage();
}
