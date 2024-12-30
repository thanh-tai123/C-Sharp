using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Acme.PhamacyManagement.IServices;
using Acme.PhamacyManagement.Services;
using Autofac;

namespace Acme.PhamacyManagement;
[DependsOn(
    typeof(PhamacyManagementDomainModule),
    typeof(PhamacyManagementApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class PhamacyManagementApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<PhamacyManagementApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<PhamacyManagementApplicationModule>();
        });

        var services = context.Services;

        // Register the IAcountsServices interface with its implementation
        services.AddTransient<IWarehouseServices, WarehouseService>();

        //services.AddTransient<IProductsServices, ProductsServices>();
    }
    public void ConfigureContainer(ContainerBuilder builder)
    {
        builder.RegisterAssemblyModules(typeof(PhamacyManagementApplicationModule).Assembly);
    }
}
