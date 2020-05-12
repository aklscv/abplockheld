using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace LockHeld.EntityFrameworkCore
{
    public static class LockHeldDbContextModelCreatingExtensions
    {
        public static void ConfigureLockHeld(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(LockHeldConsts.DbTablePrefix + "YourEntities", LockHeldConsts.DbSchema);

            //    //...
            //});
        }
    }
}