using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Userdefinedroomevents;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Userdefinedroomevents;

internal class UpdateTriggerMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new UpdateTriggerMessage();
}
