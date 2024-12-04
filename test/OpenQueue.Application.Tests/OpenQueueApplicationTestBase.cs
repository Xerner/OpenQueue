using Volo.Abp.Modularity;

namespace OpenQueue;

public abstract class OpenQueueApplicationTestBase<TStartupModule> : OpenQueueTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
