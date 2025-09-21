using System;
using System.Threading;
using System.Threading.Tasks;
using Turbo.Crypto;
using Turbo.Messages.Registry;
using Turbo.Primitives.Messages.Incoming.Handshake;
using Turbo.Primitives.Messages.Outgoing.Handshake;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.PacketHandlers;

public class Revision20240709Handlers(IDiffieService diffieService)
    : IMessageHandler<CompleteDiffieHandshakeMessage>,
        IMessageHandler<DisconnectMessage>,
        IMessageHandler<InfoRetrieveMessage>,
        IMessageHandler<InitDiffieHandshakeMessage>,
        IMessageHandler<SSOTicketMessage>,
        IMessageHandler<UniqueIdMessage>,
        IMessageHandler<VersionCheckMessage>
{
    private readonly IDiffieService _diffieService = diffieService;

    public async Task HandleAsync(
        CompleteDiffieHandshakeMessage message,
        MessageContext ctx,
        CancellationToken ct
    )
    {
        var sharedKey = _diffieService.GetSharedKey(message.SharedKey);

        await ctx.Session.SendComposerAsync(
            new CompleteDiffieHandshakeComposer { PublicKey = _diffieService.GetPublicKey() },
            ct
        );

        ctx.Session.SetupEncryption(sharedKey);
    }

    public async Task HandleAsync(
        DisconnectMessage message,
        MessageContext ctx,
        CancellationToken ct
    )
    {
        await Task.CompletedTask;
    }

    public Task HandleAsync(InfoRetrieveMessage message, MessageContext ctx, CancellationToken ct)
    {
        return Task.CompletedTask;
        //var player = await _playerManager.GetPlayerGrain(ctx.Session.PlayerId);
        //var summary = await player.GetAsync();

        //await ctx.Session.SendComposerAsync(new UserObjectMessage { Player = summary }, ct);
    }

    public async Task HandleAsync(
        InitDiffieHandshakeMessage message,
        MessageContext ctx,
        CancellationToken ct
    )
    {
        var prime = _diffieService.GetSignedPrime();
        var generator = _diffieService.GetSignedGenerator();

        await ctx.Session.SendComposerAsync(
            new InitDiffieHandshakeComposer { Prime = prime, Generator = generator },
            ct
        );
    }

    public async Task HandleAsync(
        SSOTicketMessage message,
        MessageContext ctx,
        CancellationToken ct
    )
    {
        var ticket = message.SSO;

        /* var result = await _authorizationManager.AuthorizeAsync(ctx, new LoginPolicy());

        if (!result.Succeeded)
        {
            Console.WriteLine(result.Failures.ToString());
        } */

        ctx.Session.SetPlayerId(1);

        await ctx.Session.SendComposerAsync(
            new AuthenticationOKMessage
            {
                AccountId = (int)ctx.Session.PlayerId,
                SuggestedLoginActions = Array.Empty<short>(),
                IdentityId = (int)ctx.Session.PlayerId,
            },
            ct
        );

        await ctx.Session.SendComposerAsync(new ScrSendUserInfoMessage(), ct);
    }

    public async Task HandleAsync(UniqueIdMessage message, MessageContext ctx, CancellationToken ct)
    {
        await Task.CompletedTask;
    }

    public async Task HandleAsync(
        VersionCheckMessage message,
        MessageContext ctx,
        CancellationToken ct
    )
    {
        await Task.CompletedTask;
    }
}
