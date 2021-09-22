using System.Threading.Tasks;
using Abp.Application.Services;
using CMS.Sessions.Dto;

namespace CMS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
