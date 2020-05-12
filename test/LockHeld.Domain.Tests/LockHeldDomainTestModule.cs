using LockHeld.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LockHeld
{
    [DependsOn(
        typeof(LockHeldEntityFrameworkCoreTestModule)
        )]
    public class LockHeldDomainTestModule : AbpModule
    {

    }
}