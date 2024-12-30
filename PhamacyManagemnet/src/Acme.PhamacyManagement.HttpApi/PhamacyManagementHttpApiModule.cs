using Localization.Resources.AbpUi;
using Acme.PhamacyManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Acme.PhamacyManagement;

[DependsOn(
    typeof(PhamacyManagementApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class PhamacyManagementHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(PhamacyManagementHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<PhamacyManagementResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
