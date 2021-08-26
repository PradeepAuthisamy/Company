using Volo.Abp.Settings;

namespace Company.Settings
{
    public class CompanySettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CompanySettings.MySetting1));
        }
    }
}
