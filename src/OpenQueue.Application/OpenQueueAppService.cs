using OpenQueue.Localization;
using Volo.Abp.Application.Services;

namespace OpenQueue;

/* Inherit your application services from this class.
 */
public abstract class OpenQueueAppService : ApplicationService
{
    protected OpenQueueAppService()
    {
        LocalizationResource = typeof(OpenQueueResource);
    }
}
