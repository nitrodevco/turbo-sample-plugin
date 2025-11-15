using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Room.Furniture;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Furniture;

internal class GetYoutubeDisplayStatusMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetYoutubeDisplayStatusMessage();
}
