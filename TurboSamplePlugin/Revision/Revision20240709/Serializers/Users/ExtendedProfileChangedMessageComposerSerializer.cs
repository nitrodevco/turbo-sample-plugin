using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class ExtendedProfileChangedMessageComposerSerializer(int header)
    : AbstractSerializer<ExtendedProfileChangedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ExtendedProfileChangedMessageComposer message
    )
    {
        //
    }
}
