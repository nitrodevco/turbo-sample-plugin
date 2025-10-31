using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Quest;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Quest;

internal class SeasonalQuestsMessageComposerSerializer(int header)
    : AbstractSerializer<SeasonalQuestsMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, SeasonalQuestsMessageComposer message)
    {
        //
    }
}
