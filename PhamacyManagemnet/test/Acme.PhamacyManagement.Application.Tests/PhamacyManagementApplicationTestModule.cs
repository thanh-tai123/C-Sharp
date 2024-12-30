using Volo.Abp.Modularity;

namespace Acme.PhamacyManagement;

[DependsOn(
    typeof(PhamacyManagementApplicationModule),
    typeof(PhamacyManagementDomainTestModule)
    )]
public class PhamacyManagementApplicationTestModule : AbpModule
{

}
