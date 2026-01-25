using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Turbo.Contracts.Plugins;
using Turbo.Primitives.Networking.Revisions;
using TurboSamplePlugin.Revision.Revision20260112;
using TurboSamplePlugin.Revision.RevisionDefault;

namespace TurboSamplePlugin;

public class SamplePluginService(IHostServices host, ILogger<SamplePluginService> logger)
    : IHostedService
{
    private readonly IHostServices _host = host;
    private readonly ILogger<SamplePluginService> _logger = logger;

    public Task StartAsync(CancellationToken ct)
    {
        try
        {
            var revisionManager = _host.GetRequiredService<IRevisionManager>();

            if (revisionManager is not null)
            {
                revisionManager.RegisterRevision(new RevisionDefault());
                revisionManager.RegisterRevision(new Revision20260112());
            }

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

        return Task.CompletedTask;
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        //_logger.LogInformation("{GetVersion} StopAsync...", GetVersion());

        await Task.CompletedTask;
    }
}
