using Acme.PhamacyManagement.Localization;
using Volo.Abp.Application.Services;

namespace Acme.PhamacyManagement;

public abstract class PhamacyManagementAppService : ApplicationService
{
    protected PhamacyManagementAppService()
    {
        LocalizationResource = typeof(PhamacyManagementResource);
        ObjectMapperContext = typeof(PhamacyManagementApplicationModule);
    }
}
