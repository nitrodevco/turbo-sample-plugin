using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Quest;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Quest;

internal class EpicPopupMessageComposerSerializer(int header)
    : AbstractSerializer<EpicPopupMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, EpicPopupMessageComposer message)
    {
        //
    }
}
