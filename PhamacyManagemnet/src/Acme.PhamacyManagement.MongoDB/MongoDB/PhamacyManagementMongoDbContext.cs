using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Acme.PhamacyManagement.MongoDB;

[ConnectionStringName(PhamacyManagementDbProperties.ConnectionStringName)]
public class PhamacyManagementMongoDbContext : AbpMongoDbContext, IPhamacyManagementMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigurePhamacyManagement();
    }
}
