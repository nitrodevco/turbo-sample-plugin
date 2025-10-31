using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Callforhelp;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Callforhelp;

internal class SanctionStatusEventMessageComposerSerializer(int header)
    : AbstractSerializer<SanctionStatusEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        SanctionStatusEventMessageComposer message
    )
    {
        //
    }
}
