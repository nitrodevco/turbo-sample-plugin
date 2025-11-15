using Turbo.Primitives.Messages.Outgoing.Groupforums;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Groupforums;

internal class UpdateThreadMessageComposerSerializer(int header)
    : AbstractSerializer<UpdateThreadMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, UpdateThreadMessageComposer message)
    {
        //
    }
}
