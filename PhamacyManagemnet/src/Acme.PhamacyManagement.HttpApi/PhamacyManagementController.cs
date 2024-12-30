using Acme.PhamacyManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.PhamacyManagement;

public abstract class PhamacyManagementController : AbpControllerBase
{
    protected PhamacyManagementController()
    {
        LocalizationResource = typeof(PhamacyManagementResource);
    }
}
