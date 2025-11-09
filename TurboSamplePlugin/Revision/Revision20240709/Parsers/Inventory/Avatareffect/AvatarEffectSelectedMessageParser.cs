using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Inventory.Avatareffect;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Avatareffect;

internal class AvatarEffectSelectedMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new AvatarEffectSelectedMessage();
}
