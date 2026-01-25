using Turbo.Primitives.Messages.Outgoing.Notifications;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Notifications;

internal class ElementPointerMessageComposerSerializer(int header)
    : AbstractSerializer<ElementPointerMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ElementPointerMessageComposer message)
    {
        //
    }
}
