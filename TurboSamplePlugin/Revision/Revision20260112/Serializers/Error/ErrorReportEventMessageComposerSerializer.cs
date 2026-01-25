using Turbo.Primitives.Messages.Outgoing.Error;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Error;

internal class ErrorReportEventMessageComposerSerializer(int header)
    : AbstractSerializer<ErrorReportEventMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ErrorReportEventMessageComposer message)
    {
        //
    }
}
