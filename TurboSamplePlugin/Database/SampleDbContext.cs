using Microsoft.EntityFrameworkCore;
using Turbo.Database.Context;
using Turbo.Database.Delegates;

namespace TurboSamplePlugin.Database;

public class SampleDbContext(DbContextOptions<SampleDbContext> options, TablePrefixProvider prefix)
    : PluginDbContextBase<SampleDbContext>(options, prefix)
{
    public DbSet<SampleEntity> SampleEntities => Set<SampleEntity>();
}
