using Turbo.Primitives.Messages.Incoming.Room.Layout;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Room.Layout;

internal class UpdateFloorPropertiesMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new UpdateFloorPropertiesMessage();
}
