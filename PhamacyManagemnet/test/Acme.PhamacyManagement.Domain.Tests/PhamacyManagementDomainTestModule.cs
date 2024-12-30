using Acme.PhamacyManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.PhamacyManagement;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(PhamacyManagementEntityFrameworkCoreTestModule)
    )]
public class PhamacyManagementDomainTestModule : AbpModule
{

}
