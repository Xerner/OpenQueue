using OpenQueue.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace OpenQueue.Permissions;

public class OpenQueuePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(OpenQueuePermissions.GroupName);

        var booksPermission = myGroup.AddPermission(OpenQueuePermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(OpenQueuePermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(OpenQueuePermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(OpenQueuePermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(OpenQueuePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<OpenQueueResource>(name);
    }
}
