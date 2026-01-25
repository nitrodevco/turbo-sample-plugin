using Turbo.Primitives.Messages.Incoming.Users;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Users;

internal class GetGuildEditorDataMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetGuildEditorDataMessage();
}
