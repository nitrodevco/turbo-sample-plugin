using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Competition;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Competition;

internal class SecondsUntilMessageComposerSerializer(int header)
    : AbstractSerializer<SecondsUntilMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, SecondsUntilMessageComposer message)
    {
        //
    }
}
