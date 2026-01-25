using Turbo.Primitives.Messages.Outgoing.Navigator;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20260112.Serializers.Navigator.Data;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Navigator;

internal class CategoriesWithVisitorCountMessageComposerSerializer(int header)
    : AbstractSerializer<CategoriesWithVisitorCountMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CategoriesWithVisitorCountMessageComposer message
    )
    {
        CategoriesWithVisitorCountSerializer.Serialize(packet, message.Categories);
    }
}
