using Turbo.Primitives.Messages.Incoming.Userdefinedroomevents.Wiredmenu;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Userdefinedroomevents.Wiredmenu;

internal class WiredGetAllVariableHoldersMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new WiredGetAllVariableHoldersMessage();
}
