using Volo.Abp.Modularity;

namespace LockHeld
{
    [DependsOn(
        typeof(LockHeldApplicationModule),
        typeof(LockHeldDomainTestModule)
        )]
    public class LockHeldApplicationTestModule : AbpModule
    {

    }
}