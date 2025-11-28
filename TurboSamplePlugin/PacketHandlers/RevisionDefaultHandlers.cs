using System.Threading;
using System.Threading.Tasks;
using Turbo.Messages.Registry;
using Turbo.Primitives.Messages.Incoming.Handshake;

namespace TurboSamplePlugin.PacketHandlers;

public class RevisionDefaultHandlers : IMessageHandler<ClientHelloMessage>
{
    public async ValueTask HandleAsync(
        ClientHelloMessage message,
        MessageContext ctx,
        CancellationToken ct
    )
    {
        if (message.Production is null)
        {
            await ctx.CloseSessionAsync().ConfigureAwait(false);

            return;
        }

        ctx.SetRevisionId(message.Production);
    }
}
