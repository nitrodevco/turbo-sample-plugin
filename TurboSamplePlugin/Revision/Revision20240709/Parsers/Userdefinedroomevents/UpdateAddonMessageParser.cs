using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Userdefinedroomevents;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Userdefinedroomevents;

internal class UpdateAddonMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new UpdateAddonMessage();
}
