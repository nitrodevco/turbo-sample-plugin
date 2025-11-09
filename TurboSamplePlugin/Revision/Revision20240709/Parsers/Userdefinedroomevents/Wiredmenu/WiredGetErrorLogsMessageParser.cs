using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Userdefinedroomevents.Wiredmenu;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Userdefinedroomevents.Wiredmenu;

internal class WiredGetErrorLogsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new WiredGetErrorLogsMessage();
}
