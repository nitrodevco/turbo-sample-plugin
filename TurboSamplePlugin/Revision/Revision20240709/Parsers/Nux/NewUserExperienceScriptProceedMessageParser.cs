using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Nux;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Nux;

internal class NewUserExperienceScriptProceedMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new NewUserExperienceScriptProceedMessage();
}
