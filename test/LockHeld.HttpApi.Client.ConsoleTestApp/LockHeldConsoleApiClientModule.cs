using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace LockHeld.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(LockHeldHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class LockHeldConsoleApiClientModule : AbpModule
    {
        
    }
}
