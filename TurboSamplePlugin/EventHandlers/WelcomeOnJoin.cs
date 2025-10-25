using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Turbo.Events.Registry;
using Turbo.Primitives.Events;

namespace TurboSamplePlugin.EventHandlers;

public class WelcomeOnJoin(ILogger<PlayerJoinedEvent> logger)
    : IEventBehavior<PlayerJoinedEvent>,
        IEventHandler<PlayerJoinedEvent>
{
    private readonly ILogger<PlayerJoinedEvent> _logger = logger;

    public async ValueTask InvokeAsync(
        PlayerJoinedEvent e,
        EventContext ctx,
        Func<ValueTask> next,
        CancellationToken ct
    )
    {
        _logger.LogDebug("Begin PlayerJoined {Id}", e.PlayerId);
        try
        {
            await next();
        }
        finally
        {
            _logger.LogDebug("End PlayerJoined {Id}", e.PlayerId);
        }
    }

    public async ValueTask HandleAsync(PlayerJoinedEvent e, EventContext ctx, CancellationToken ct)
    {
        Console.WriteLine($"Welcome player {e.PlayerId}");

        await Task.CompletedTask;
    }
}
