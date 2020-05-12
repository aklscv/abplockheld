using System.Threading.Tasks;

namespace LockHeld.Data
{
    public interface ILockHeldDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
