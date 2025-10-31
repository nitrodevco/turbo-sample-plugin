using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Groupforums;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Groupforums;

internal class UpdateThreadMessageComposerSerializer(int header)
    : AbstractSerializer<UpdateThreadMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, UpdateThreadMessageComposer message)
    {
        //
    }
}
