using Turbo.Primitives.Messages.Incoming.Userdefinedroomevents.Wiredmenu;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Userdefinedroomevents.Wiredmenu;

internal class WiredGetRoomSettingsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new WiredGetRoomSettingsMessage();
}
