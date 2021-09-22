using System.Threading.Tasks;
using Abp.Application.Services;
using CMS.Authorization.Accounts.Dto;

namespace CMS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
