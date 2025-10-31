using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Moderation;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Moderation;

internal class UserBannedMessageComposerSerializer(int header)
    : AbstractSerializer<UserBannedMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, UserBannedMessageComposer message)
    {
        //
    }
}
