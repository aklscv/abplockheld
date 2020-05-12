using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LockHeld.Data
{
    /* This is used if database provider does't define
     * ILockHeldDbSchemaMigrator implementation.
     */
    public class NullLockHeldDbSchemaMigrator : ILockHeldDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}