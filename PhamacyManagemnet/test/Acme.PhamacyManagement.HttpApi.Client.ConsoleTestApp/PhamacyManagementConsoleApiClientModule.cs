using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Acme.PhamacyManagement;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PhamacyManagementHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class PhamacyManagementConsoleApiClientModule : AbpModule
{

}
