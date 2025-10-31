using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Callforhelp;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Callforhelp;

internal class CfhSanctionMessageComposerSerializer(int header)
    : AbstractSerializer<CfhSanctionMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, CfhSanctionMessageComposer message)
    {
        //
    }
}
