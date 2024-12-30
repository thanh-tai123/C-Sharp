using Volo.Abp.Reflection;

namespace Acme.PhamacyManagement.Permissions;

public class PhamacyManagementPermissions
{
    public const string GroupName = "PhamacyManagement";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(PhamacyManagementPermissions));
    }
}
