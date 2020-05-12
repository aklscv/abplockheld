using Volo.Abp.Settings;

namespace LockHeld.Settings
{
    public class LockHeldSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(LockHeldSettings.MySetting1));
        }
    }
}
