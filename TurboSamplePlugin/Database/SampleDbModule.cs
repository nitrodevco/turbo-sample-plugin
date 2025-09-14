using System;
using System.Threading;
using System.Threading.Tasks;
using Turbo.Contracts.Plugins;
using Turbo.Database.Migrations;

namespace TurboSamplePlugin.Database;

public class SampleDbModule : IPluginDbModule
{
    public async Task MigrateAsync(IServiceProvider sp, CancellationToken ct)
    {
        await MigrationHelper.MigrateAsync<SampleDbContext>(sp, ct);
    }

    public async Task UninstallAsync(IServiceProvider sp, CancellationToken ct)
    {
        await MigrationHelper.UninstallAsync<SampleDbContext>(sp, ct);
    }
}
