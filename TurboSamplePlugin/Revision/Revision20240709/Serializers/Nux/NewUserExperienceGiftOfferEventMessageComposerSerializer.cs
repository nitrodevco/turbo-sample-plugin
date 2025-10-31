using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Nux;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Nux;

internal class NewUserExperienceGiftOfferEventMessageComposerSerializer(int header)
    : AbstractSerializer<NewUserExperienceGiftOfferEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        NewUserExperienceGiftOfferEventMessageComposer message
    )
    {
        //
    }
}
