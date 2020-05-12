using LockHeld.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace LockHeld.Permissions
{
    public class LockHeldPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(LockHeldPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(LockHeldPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<LockHeldResource>(name);
        }
    }
}
