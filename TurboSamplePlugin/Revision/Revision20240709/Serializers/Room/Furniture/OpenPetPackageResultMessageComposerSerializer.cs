using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Furniture;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Furniture;

internal class OpenPetPackageResultMessageComposerSerializer(int header)
    : AbstractSerializer<OpenPetPackageResultMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        OpenPetPackageResultMessageComposer message
    )
    {
        packet
            .WriteInteger(message.ObjectId)
            .WriteInteger(message.NameValidationStatus)
            .WriteString(message.NameValidationInfo);
    }
}
