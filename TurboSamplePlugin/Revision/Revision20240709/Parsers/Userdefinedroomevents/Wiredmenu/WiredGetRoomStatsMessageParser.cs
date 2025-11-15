using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Userdefinedroomevents.Wiredmenu;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Userdefinedroomevents.Wiredmenu;

internal class WiredGetRoomStatsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new WiredGetRoomStatsMessage();
}
