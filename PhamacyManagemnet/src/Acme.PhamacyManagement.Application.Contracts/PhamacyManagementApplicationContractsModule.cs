using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Acme.PhamacyManagement;

[DependsOn(
    typeof(PhamacyManagementDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class PhamacyManagementApplicationContractsModule : AbpModule
{

}
