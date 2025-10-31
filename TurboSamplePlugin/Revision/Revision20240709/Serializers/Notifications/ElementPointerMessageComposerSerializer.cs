using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Notifications;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Notifications;

internal class ElementPointerMessageComposerSerializer(int header)
    : AbstractSerializer<ElementPointerMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ElementPointerMessageComposer message)
    {
        //
    }
}
