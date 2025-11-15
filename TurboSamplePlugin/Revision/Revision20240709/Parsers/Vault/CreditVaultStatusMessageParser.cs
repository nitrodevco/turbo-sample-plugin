using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Vault;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Vault;

internal class CreditVaultStatusMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new CreditVaultStatusMessage();
}
