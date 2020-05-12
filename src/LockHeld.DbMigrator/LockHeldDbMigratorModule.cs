using LockHeld.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace LockHeld.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(LockHeldEntityFrameworkCoreDbMigrationsModule),
        typeof(LockHeldApplicationContractsModule)
        )]
    public class LockHeldDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
