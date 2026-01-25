using Turbo.Primitives.Messages.Incoming.Userdefinedroomevents.Wiredmenu;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Userdefinedroomevents.Wiredmenu;

internal class WiredGetAllVariablesHashMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new WiredGetAllVariablesHashMessage();
}
