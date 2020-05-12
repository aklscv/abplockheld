using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace LockHeld.EntityFrameworkCore
{
    [DependsOn(
        typeof(LockHeldEntityFrameworkCoreModule)
        )]
    public class LockHeldEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<LockHeldMigrationsDbContext>();
        }
    }
}
