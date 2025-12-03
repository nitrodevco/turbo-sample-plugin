using Turbo.Primitives.Messages.Outgoing.Notifications;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Notifications;

internal class InfoFeedEnableMessageComposerSerializer(int header)
    : AbstractSerializer<InfoFeedEnableMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, InfoFeedEnableMessageComposer message)
    {
        packet.WriteBoolean(message.Enabled);
    }
}
