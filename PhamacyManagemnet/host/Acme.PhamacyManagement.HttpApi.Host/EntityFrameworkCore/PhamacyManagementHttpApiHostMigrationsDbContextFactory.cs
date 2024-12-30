using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.PhamacyManagement.EntityFrameworkCore;

public class PhamacyManagementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<PhamacyManagementHttpApiHostMigrationsDbContext>
{
    public PhamacyManagementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<PhamacyManagementHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("PhamacyManagement"));

        return new PhamacyManagementHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
