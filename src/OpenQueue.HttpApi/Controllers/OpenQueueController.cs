using OpenQueue.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OpenQueue.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class OpenQueueController : AbpControllerBase
{
    protected OpenQueueController()
    {
        LocalizationResource = typeof(OpenQueueResource);
    }
}
