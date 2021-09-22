using System.Threading.Tasks;
using CMS.Configuration.Dto;

namespace CMS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
