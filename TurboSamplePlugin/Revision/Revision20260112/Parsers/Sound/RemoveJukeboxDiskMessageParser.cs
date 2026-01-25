using Turbo.Primitives.Messages.Incoming.Sound;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Sound;

internal class RemoveJukeboxDiskMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new RemoveJukeboxDiskMessage();
}
