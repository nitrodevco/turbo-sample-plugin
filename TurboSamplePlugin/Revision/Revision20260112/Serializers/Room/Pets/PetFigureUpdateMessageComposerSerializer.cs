using Turbo.Primitives.Messages.Outgoing.Room.Pets;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Room.Pets;

internal class PetFigureUpdateMessageComposerSerializer(int header)
    : AbstractSerializer<PetFigureUpdateMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, PetFigureUpdateMessageComposer message)
    {
        //
    }
}
