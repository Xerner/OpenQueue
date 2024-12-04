using Microsoft.Extensions.Localization;
using OpenQueue.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace OpenQueue;

[Dependency(ReplaceServices = true)]
public class OpenQueueBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<OpenQueueResource> _localizer;

    public OpenQueueBrandingProvider(IStringLocalizer<OpenQueueResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
