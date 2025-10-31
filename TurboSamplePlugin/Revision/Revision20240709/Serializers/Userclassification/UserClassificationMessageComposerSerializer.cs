using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Userclassification;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userclassification;

internal class UserClassificationMessageComposerSerializer(int header)
    : AbstractSerializer<UserClassificationMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        UserClassificationMessageComposer message
    )
    {
        //
    }
}
