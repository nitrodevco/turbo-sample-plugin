using Turbo.Primitives.Messages.Incoming.Navigator;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Navigator;

internal class CancelEventMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new CancelEventMessage { AdvertisementId = packet.PopInt() };
}
