using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class CategoriesWithVisitorCountMessageComposerSerializer(int header)
    : AbstractSerializer<CategoriesWithVisitorCountMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CategoriesWithVisitorCountMessageComposer message
    )
    {
        //
    }
}
