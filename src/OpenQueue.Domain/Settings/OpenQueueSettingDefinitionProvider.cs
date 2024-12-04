using Volo.Abp.Settings;

namespace OpenQueue.Settings;

public class OpenQueueSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(OpenQueueSettings.MySetting1));
    }
}
