using Abp.Authorization;
using CMS.Authorization.Roles;
using CMS.Authorization.Users;

namespace CMS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
