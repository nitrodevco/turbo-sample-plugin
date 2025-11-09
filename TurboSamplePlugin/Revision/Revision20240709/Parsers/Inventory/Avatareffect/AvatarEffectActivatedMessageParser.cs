using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Inventory.Avatareffect;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Avatareffect;

internal class AvatarEffectActivatedMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new AvatarEffectActivatedMessage();
}
