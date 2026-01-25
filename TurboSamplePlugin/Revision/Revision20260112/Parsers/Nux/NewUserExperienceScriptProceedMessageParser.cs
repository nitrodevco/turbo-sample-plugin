using Turbo.Primitives.Messages.Incoming.Nux;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Nux;

internal class NewUserExperienceScriptProceedMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new NewUserExperienceScriptProceedMessage();
}
