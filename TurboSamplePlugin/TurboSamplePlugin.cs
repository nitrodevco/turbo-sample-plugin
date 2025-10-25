using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Turbo.Contracts.Plugins;
using Turbo.Contracts.Plugins.Exports;
using Turbo.Database.Extensions;
using TurboSamplePlugin.Database;

namespace TurboSamplePlugin;

public class TurboSamplePlugin : ITurboPlugin
{
    public string Key => "turbo-sample-plugin";
    public string Version => "1.0.0";

    public async Task BindExportsAsync(IExportBinder binder, IServiceProvider services)
    {
        await Task.CompletedTask;
    }

    public void ConfigureServices(IServiceCollection services, PluginManifest manifest)
    {
        services.AddPluginDatabaseContext<SampleDbContext, SampleDbModule>();

        services.AddSingleton<SamplePluginService>();
    }

    public async Task StartAsync(IServiceProvider sp, CancellationToken ct)
    {
        var samplePluginService = sp.GetRequiredService<SamplePluginService>();

        await samplePluginService.StartAsync(ct);
    }

    public async Task StopAsync(CancellationToken ct)
    {
        await Task.CompletedTask;
    }

    public async ValueTask DisposeAsync()
    {
        // Cleanup resources if needed
        await ValueTask.CompletedTask;
    }
}
