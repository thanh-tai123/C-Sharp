using Acme.PhamacyManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.PhamacyManagement.Permissions;

public class PhamacyManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PhamacyManagementPermissions.GroupName, L("Permission:PhamacyManagement"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PhamacyManagementResource>(name);
    }
}
