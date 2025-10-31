using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Moderation;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Moderation;

internal class UserChatlogEventMessageComposerSerializer(int header)
    : AbstractSerializer<UserChatlogEventMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, UserChatlogEventMessageComposer message)
    {
        //
    }
}
