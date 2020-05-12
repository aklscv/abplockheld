using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LockHeld.Data;
using Volo.Abp.DependencyInjection;

namespace LockHeld.EntityFrameworkCore
{
    public class EntityFrameworkCoreLockHeldDbSchemaMigrator
        : ILockHeldDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreLockHeldDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the LockHeldMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<LockHeldMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}