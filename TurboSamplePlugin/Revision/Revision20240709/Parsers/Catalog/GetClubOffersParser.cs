using Turbo.Contracts.Abstractions;
using Turbo.Contracts.Enums.Catalog;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Catalog;

public class GetClubOffersParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new GetClubOffersMessage { RequestSource = (ClubOfferRequestSourceEnum)packet.PopInt() };
}
