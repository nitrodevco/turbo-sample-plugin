using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class RelationshipStatusInfoEventMessageComposerSerializer(int header)
    : AbstractSerializer<RelationshipStatusInfoEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        RelationshipStatusInfoEventMessageComposer message
    )
    {
        //
    }
}
