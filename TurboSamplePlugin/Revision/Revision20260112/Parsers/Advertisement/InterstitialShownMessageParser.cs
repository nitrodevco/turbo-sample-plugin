using Turbo.Primitives.Messages.Incoming.Advertisement;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Advertisement;

internal class InterstitialShownMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new InterstitialShownMessage();
}
