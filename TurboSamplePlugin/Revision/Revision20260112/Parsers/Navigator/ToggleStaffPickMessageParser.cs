using Turbo.Primitives.Messages.Incoming.Navigator;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Navigator;

internal class ToggleStaffPickMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new ToggleStaffPickMessage
        {
            RoomId = packet.PopInt(),
            IsStaffPicked = packet.PopBoolean(),
        };
}
