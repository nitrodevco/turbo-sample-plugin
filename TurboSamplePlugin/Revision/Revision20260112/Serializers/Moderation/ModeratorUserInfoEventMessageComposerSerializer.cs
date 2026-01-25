using Turbo.Primitives.Messages.Outgoing.Moderation;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Moderation;

internal class ModeratorUserInfoEventMessageComposerSerializer(int header)
    : AbstractSerializer<ModeratorUserInfoEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ModeratorUserInfoEventMessageComposer message
    )
    {
        //
    }
}
