using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class GuideReportingStatusMessageComposerSerializer(int header)
    : AbstractSerializer<GuideReportingStatusMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GuideReportingStatusMessageComposer message
    )
    {
        //
    }
}
