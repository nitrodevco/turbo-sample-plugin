using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Groupforums;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Groupforums;

internal class UpdateForumSettingsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new UpdateForumSettingsMessage();
}
