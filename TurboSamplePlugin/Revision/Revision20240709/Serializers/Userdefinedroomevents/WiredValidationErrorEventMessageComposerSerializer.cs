using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents;

internal class WiredValidationErrorEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredValidationErrorEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredValidationErrorEventMessageComposer message
    )
    {
        packet.WriteString(message.LocalizationKey).WriteInteger(message.Parameters.Count);

        foreach (var (key, value) in message.Parameters)
            packet.WriteString(key).WriteString(value);
    }
}
