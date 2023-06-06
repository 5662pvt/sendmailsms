using sendmailsms.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace sendmailsms.Permissions;

public class sendmailsmsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(sendmailsmsPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(sendmailsmsPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<sendmailsmsResource>(name);
    }
}
