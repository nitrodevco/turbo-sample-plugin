using Turbo.Primitives.Messages.Incoming.Navigator;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Navigator;

internal class SetRoomSessionTagsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new SetRoomSessionTagsMessage { Tag1 = packet.PopString(), Tag2 = packet.PopString() };
}
