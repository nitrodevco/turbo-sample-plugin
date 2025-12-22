using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents;

internal class OpenEventMessageComposerSerializer(int header)
    : AbstractSerializer<OpenEventMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, OpenEventMessageComposer message)
    {
        packet.WriteInteger(message.ItemId);
    }
}
