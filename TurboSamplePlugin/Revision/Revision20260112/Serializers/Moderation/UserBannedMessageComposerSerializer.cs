using Turbo.Primitives.Messages.Outgoing.Moderation;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Moderation;

internal class UserBannedMessageComposerSerializer(int header)
    : AbstractSerializer<UserBannedMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, UserBannedMessageComposer message)
    {
        //
    }
}
