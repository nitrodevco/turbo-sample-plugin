using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Notifications;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Notifications;

internal class InfoFeedEnableMessageComposerSerializer(int header)
    : AbstractSerializer<InfoFeedEnableMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, InfoFeedEnableMessageComposer message)
    {
        //
    }
}
