using Turbo.Primitives.Messages.Outgoing.Gifts;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Gifts;

internal class PhoneCollectionStateMessageComposerSerializer(int header)
    : AbstractSerializer<PhoneCollectionStateMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        PhoneCollectionStateMessageComposer message
    )
    {
        //
    }
}
