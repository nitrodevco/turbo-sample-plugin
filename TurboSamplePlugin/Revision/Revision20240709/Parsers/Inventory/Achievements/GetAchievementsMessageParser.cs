using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Inventory.Achievements;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Achievements;

internal class GetAchievementsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetAchievementsMessage();
}
