using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LockHeld.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class LockHeldMigrationsDbContextFactory : IDesignTimeDbContextFactory<LockHeldMigrationsDbContext>
    {
        public LockHeldMigrationsDbContext CreateDbContext(string[] args)
        {
            LockHeldEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<LockHeldMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new LockHeldMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
