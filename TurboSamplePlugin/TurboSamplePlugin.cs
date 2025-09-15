using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Turbo.Contracts.Plugins;
using Turbo.Database.Extensions;
using Turbo.Networking.Abstractions.Encryption;
using Turbo.Networking.Abstractions.Revisions;
using TurboSamplePlugin.Database;

namespace TurboSamplePlugin;

public class TurboSamplePlugin : ITurboPlugin
{
    public List<Type> RequiredHostServices => [typeof(IRevisionManager), typeof(IDiffieService)];

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddPluginDatabaseContext<SampleDbContext>();
        services.AddTransient<IPluginDbModule, SampleDbModule>();

        services.AddSingleton<SamplePluginService>();
    }

    public async ValueTask OnEnableAsync(IServiceProvider sp, CancellationToken ct)
    {
        var samplePluginService = sp.GetRequiredService<SamplePluginService>();

        await samplePluginService.StartAsync(ct);

        return;
    }

    public async ValueTask OnDisableAsync(IServiceProvider sp, CancellationToken ct)
    {
        var samplePluginService = sp.GetRequiredService<SamplePluginService>();

        await samplePluginService.StopAsync(ct);

        return;
    }

    public async ValueTask DisposeAsync()
    {
        // Cleanup resources if needed
        await ValueTask.CompletedTask;
    }
}
