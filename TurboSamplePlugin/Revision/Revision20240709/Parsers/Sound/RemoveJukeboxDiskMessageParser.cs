using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Sound;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Sound;

internal class RemoveJukeboxDiskMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new RemoveJukeboxDiskMessage();
}
