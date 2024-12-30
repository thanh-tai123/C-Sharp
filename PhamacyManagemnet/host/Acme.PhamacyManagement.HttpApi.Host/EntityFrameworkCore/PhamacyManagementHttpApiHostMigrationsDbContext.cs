using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.PhamacyManagement.EntityFrameworkCore;

public class PhamacyManagementHttpApiHostMigrationsDbContext : AbpDbContext<PhamacyManagementHttpApiHostMigrationsDbContext>
{
    public PhamacyManagementHttpApiHostMigrationsDbContext(DbContextOptions<PhamacyManagementHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigurePhamacyManagement();
    }
}
