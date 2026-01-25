using Turbo.Primitives.Messages.Incoming.Preferences;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Preferences;

internal class SetIgnoreRoomInvitesMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new SetIgnoreRoomInvitesMessage();
}
