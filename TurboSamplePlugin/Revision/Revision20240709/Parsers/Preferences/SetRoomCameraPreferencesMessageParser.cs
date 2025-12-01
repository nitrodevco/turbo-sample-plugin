using Turbo.Primitives.Messages.Incoming.Preferences;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Preferences;

internal class SetRoomCameraPreferencesMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new SetRoomCameraPreferencesMessage();
}
