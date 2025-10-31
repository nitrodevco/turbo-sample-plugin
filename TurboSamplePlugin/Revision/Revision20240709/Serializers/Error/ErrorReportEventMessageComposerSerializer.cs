using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Error;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Error;

internal class ErrorReportEventMessageComposerSerializer(int header)
    : AbstractSerializer<ErrorReportEventMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ErrorReportEventMessageComposer message)
    {
        //
    }
}
