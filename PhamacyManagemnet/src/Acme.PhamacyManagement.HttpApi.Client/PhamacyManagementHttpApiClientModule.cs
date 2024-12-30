using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Acme.PhamacyManagement;

[DependsOn(
    typeof(PhamacyManagementApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class PhamacyManagementHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(PhamacyManagementApplicationContractsModule).Assembly,
            PhamacyManagementRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<PhamacyManagementHttpApiClientModule>();
        });

    }
}
