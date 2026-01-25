using Turbo.Primitives.Messages.Outgoing.Navigator;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Navigator;

internal class UserEventCatsMessageComposerSerializer(int header)
    : AbstractSerializer<UserEventCatsMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, UserEventCatsMessageComposer message)
    {
        //
    }
}
