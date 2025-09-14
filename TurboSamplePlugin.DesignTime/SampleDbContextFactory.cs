using System;
using System.IO;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using Turbo.Contracts.Plugins;
using Turbo.Database.Delegates;
using TurboSamplePlugin.Database;

namespace TurboSamplePlugin.DesignTime;

public class SampleDbContextFactory : IDesignTimeDbContextFactory<SampleDbContext>
{
    // cd TurboSamplePlugin.DesignTime
    // dotnet ef migrations add Init --project ../TurboSamplePlugin/TurboSamplePlugin.csproj --startup-project . --context SampleDbContext --output-dir ../TurboSamplePlugin/Migrations
    public SampleDbContext CreateDbContext(string[] args)
    {
        LoadDotEnv();

        var services = new ServiceCollection();

        services.AddSingleton(_ =>
            JsonSerializer.Deserialize<PluginManifest>(
                File.ReadAllText("../TurboSamplePlugin/manifest.json")
            )!
        );
        services.AddSingleton<TablePrefixProvider>(sp =>
        {
            var manifest = sp.GetRequiredService<PluginManifest>();

            return () => manifest.TablePrefix ?? string.Empty;
        });

        var conn = Environment.GetEnvironmentVariable("PLUGIN_DEV_CONNECTION");

        services.AddDbContext<SampleDbContext>(
            (sp, opts) =>
            {
                var prefix = sp.GetRequiredService<TablePrefixProvider>();

                opts.UseMySql(
                    conn,
                    ServerVersion.AutoDetect(conn),
                    b =>
                    {
                        b.MigrationsAssembly(typeof(TurboSamplePlugin).Assembly.FullName);
                        b.MigrationsHistoryTable($"__EFMigrationsHistory_{prefix().TrimEnd('_')}");
                    }
                );
            }
        );

        var sp = services.BuildServiceProvider();

        return sp.GetRequiredService<SampleDbContext>();
    }

    private static void LoadDotEnv()
    {
        var path = Path.Combine("..", ".env");
        if (!File.Exists(path))
            return;

        foreach (var line in File.ReadAllLines(path))
        {
            if (string.IsNullOrWhiteSpace(line) || line.TrimStart().StartsWith("#"))
                continue;

            var parts = line.Split('=', 2);
            if (parts.Length != 2)
                continue;

            Environment.SetEnvironmentVariable(parts[0], parts[1]);
        }
    }
}
