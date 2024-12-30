using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Acme.PhamacyManagement;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(PhamacyManagementDomainSharedModule)
)]
public class PhamacyManagementDomainModule : AbpModule
{

}
