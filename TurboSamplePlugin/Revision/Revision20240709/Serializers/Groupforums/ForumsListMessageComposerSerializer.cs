using Turbo.Primitives.Messages.Outgoing.Groupforums;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Groupforums;

internal class ForumsListMessageComposerSerializer(int header)
    : AbstractSerializer<ForumsListMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ForumsListMessageComposer message)
    {
        //
    }
}
