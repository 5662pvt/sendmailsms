using Volo.Abp.Settings;

namespace sendmailsms.Settings;

public class sendmailsmsSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(sendmailsmsSettings.MySetting1));
    }
}
