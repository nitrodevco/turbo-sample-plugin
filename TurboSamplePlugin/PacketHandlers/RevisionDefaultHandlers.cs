using System.Threading;
using System.Threading.Tasks;
using SuperSocket.Connection;
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
            await ctx.Session.CloseSessionAsync().ConfigureAwait(false);

            return;
        }

        ctx.Session.SetRevisionId(message.Production);
    }
}
