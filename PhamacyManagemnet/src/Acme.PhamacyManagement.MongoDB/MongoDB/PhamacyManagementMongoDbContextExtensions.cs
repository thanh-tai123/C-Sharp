using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Acme.PhamacyManagement.MongoDB;

public static class PhamacyManagementMongoDbContextExtensions
{
    public static void ConfigurePhamacyManagement(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
