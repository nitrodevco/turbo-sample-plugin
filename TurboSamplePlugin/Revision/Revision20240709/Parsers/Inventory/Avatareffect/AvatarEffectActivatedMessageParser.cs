using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Inventory.Avatareffect;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Avatareffect;

internal class AvatarEffectActivatedMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new AvatarEffectActivatedMessage();
}
