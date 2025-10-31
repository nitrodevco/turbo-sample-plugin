using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class GuildEditorDataMessageComposerSerializer(int header)
    : AbstractSerializer<GuildEditorDataMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, GuildEditorDataMessageComposer message)
    {
        //
    }
}
