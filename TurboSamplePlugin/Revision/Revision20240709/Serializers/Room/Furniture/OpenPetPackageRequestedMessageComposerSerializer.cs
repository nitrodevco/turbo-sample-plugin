using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Furniture;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Furniture;

internal class OpenPetPackageRequestedMessageComposerSerializer(int header)
    : AbstractSerializer<OpenPetPackageRequestedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        OpenPetPackageRequestedMessageComposer message
    )
    {
        //
    }
}
