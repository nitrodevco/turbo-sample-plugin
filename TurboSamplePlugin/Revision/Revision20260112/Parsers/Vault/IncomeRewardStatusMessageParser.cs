using Turbo.Primitives.Messages.Incoming.Vault;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Vault;

internal class IncomeRewardStatusMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new IncomeRewardStatusMessage();
}
