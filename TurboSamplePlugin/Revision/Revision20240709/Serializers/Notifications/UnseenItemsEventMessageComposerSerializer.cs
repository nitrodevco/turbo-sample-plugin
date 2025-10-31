using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Notifications;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Notifications;

internal class UnseenItemsEventMessageComposerSerializer(int header)
    : AbstractSerializer<UnseenItemsEventMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, UnseenItemsEventMessageComposer message)
    {
        //
    }
}
