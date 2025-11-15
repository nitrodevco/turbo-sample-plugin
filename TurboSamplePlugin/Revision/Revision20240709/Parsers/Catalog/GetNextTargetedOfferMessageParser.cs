using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Catalog;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Catalog;

internal class GetNextTargetedOfferMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetNextTargetedOfferMessage();
}
