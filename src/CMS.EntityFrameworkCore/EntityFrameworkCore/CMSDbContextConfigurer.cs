using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CMS.EntityFrameworkCore
{
    public static class CMSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CMSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CMSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
