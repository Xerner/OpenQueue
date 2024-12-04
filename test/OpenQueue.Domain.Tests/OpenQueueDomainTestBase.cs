using Volo.Abp.Modularity;

namespace OpenQueue;

/* Inherit from this class for your domain layer tests. */
public abstract class OpenQueueDomainTestBase<TStartupModule> : OpenQueueTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
