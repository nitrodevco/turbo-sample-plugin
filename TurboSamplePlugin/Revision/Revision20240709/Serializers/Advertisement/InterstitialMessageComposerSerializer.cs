using Turbo.Primitives.Messages.Outgoing.Advertisement;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Advertisement;

internal class InterstitialMessageComposerSerializer(int header)
    : AbstractSerializer<InterstitialMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, InterstitialMessageComposer message)
    {
        //
    }
}
