using Turbo.Primitives.Messages.Incoming.Avatar;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Avatar;

internal class SaveWardrobeOutfitMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new SaveWardrobeOutfitMessage();
}
