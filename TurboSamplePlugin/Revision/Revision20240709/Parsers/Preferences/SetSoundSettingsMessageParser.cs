using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Preferences;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Preferences;

internal class SetSoundSettingsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new SetSoundSettingsMessage();
}
