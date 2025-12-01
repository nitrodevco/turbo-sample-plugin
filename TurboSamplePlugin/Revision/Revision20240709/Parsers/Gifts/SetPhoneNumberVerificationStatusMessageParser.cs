using Turbo.Primitives.Messages.Incoming.Gifts;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Gifts;

internal class SetPhoneNumberVerificationStatusMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new SetPhoneNumberVerificationStatusMessage();
}
