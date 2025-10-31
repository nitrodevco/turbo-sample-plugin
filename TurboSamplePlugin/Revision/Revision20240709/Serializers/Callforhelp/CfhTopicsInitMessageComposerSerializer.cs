using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Callforhelp;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Callforhelp;

internal class CfhTopicsInitMessageComposerSerializer(int header)
    : AbstractSerializer<CfhTopicsInitMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, CfhTopicsInitMessageComposer message)
    {
        //
    }
}
