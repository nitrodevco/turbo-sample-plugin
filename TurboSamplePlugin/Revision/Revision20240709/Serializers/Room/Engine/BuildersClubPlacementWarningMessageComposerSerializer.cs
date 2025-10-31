using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Engine;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine;

internal class BuildersClubPlacementWarningMessageComposerSerializer(int header)
    : AbstractSerializer<BuildersClubPlacementWarningMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        BuildersClubPlacementWarningMessageComposer message
    )
    {
        //
    }
}
