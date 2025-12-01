using Turbo.Primitives.Messages.Incoming.Mysterybox;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Mysterybox;

internal class MysteryBoxWaitingCanceledMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new MysteryBoxWaitingCanceledMessage();
}
