using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Nux;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Nux;

internal class NewUserExperienceNotCompleteEventMessageComposerSerializer(int header)
    : AbstractSerializer<NewUserExperienceNotCompleteEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        NewUserExperienceNotCompleteEventMessageComposer message
    )
    {
        //
    }
}
