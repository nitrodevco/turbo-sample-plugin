using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Handshake;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Handshake;

internal class AuthenticationOKMessageSerializer(int header)
    : AbstractSerializer<AuthenticationOKMessage>(header)
{
    protected override void Serialize(IServerPacket packet, AuthenticationOKMessage message)
    {
        packet.WriteInteger(message.AccountId ?? 0);
        packet.WriteInteger(message.SuggestedLoginActions?.Length ?? 0);
        if (message.SuggestedLoginActions != null)
        {
            foreach (var action in message.SuggestedLoginActions)
            {
                packet.WriteShort(action);
            }
        }

        packet.WriteInteger(message.IdentityId ?? 0);
    }
}
