using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Mysterybox;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Mysterybox;

internal class MysteryBoxWaitingCanceledMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new MysteryBoxWaitingCanceledMessage();
}
