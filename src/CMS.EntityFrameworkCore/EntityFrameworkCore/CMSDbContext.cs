using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CMS.Authorization.Roles;
using CMS.Authorization.Users;
using CMS.MultiTenancy;

namespace CMS.EntityFrameworkCore
{
    public class CMSDbContext : AbpZeroDbContext<Tenant, Role, User, CMSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CMSDbContext(DbContextOptions<CMSDbContext> options)
            : base(options)
        {
        }
    }
}
