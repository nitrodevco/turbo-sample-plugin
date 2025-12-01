using Turbo.Primitives.Messages.Incoming.Userdefinedroomevents;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Userdefinedroomevents;

internal class UpdateVariableMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new UpdateVariableMessage();
}
