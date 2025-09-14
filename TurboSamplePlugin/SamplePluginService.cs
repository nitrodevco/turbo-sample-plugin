using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Turbo.Networking.Abstractions.Revisions;
using TurboSamplePlugin.Revision.Revision20240709;
using TurboSamplePlugin.Revision.RevisionDefault;

namespace TurboSamplePlugin;

public class SamplePluginService(
    IRevisionManager revisionManager,
    ILogger<SamplePluginService> logger
) : IHostedService
{
    private readonly IRevisionManager _revisionManager = revisionManager;
    private readonly ILogger<SamplePluginService> _logger = logger;

    public async Task StartAsync(CancellationToken ct)
    {
        try
        {
            _revisionManager.RegisterRevision(new RevisionDefault());
            _revisionManager.RegisterRevision(new Revision20240709());

            _logger.LogInformation("SamplePluginService started successfully.");
        }
        catch (OperationCanceledException)
        {
            _logger.LogInformation("SamplePluginService startup was cancelled.");

            throw;
        }
        catch (Exception ex)
        {
            _logger.LogCritical(ex, "SamplePluginService failed to start!");

            throw;
        }
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        //_logger.LogInformation("{GetVersion} StopAsync...", GetVersion());

        await Task.CompletedTask;
    }
}
