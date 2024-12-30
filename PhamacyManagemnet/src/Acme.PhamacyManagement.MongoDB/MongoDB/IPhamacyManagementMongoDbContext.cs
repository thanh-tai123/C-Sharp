using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Acme.PhamacyManagement.MongoDB;

[ConnectionStringName(PhamacyManagementDbProperties.ConnectionStringName)]
public interface IPhamacyManagementMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
