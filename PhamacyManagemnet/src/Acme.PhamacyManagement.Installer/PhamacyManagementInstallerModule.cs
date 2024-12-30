using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Acme.PhamacyManagement;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class PhamacyManagementInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<PhamacyManagementInstallerModule>();
        });
    }
}
