using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Groupforums;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Groupforums;

internal class UpdateMessageMessageComposerSerializer(int header)
    : AbstractSerializer<UpdateMessageMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, UpdateMessageMessageComposer message)
    {
        //
    }
}
