using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Advertisement;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Advertisement;

internal class GetInterstitialMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetInterstitialMessage();
}
