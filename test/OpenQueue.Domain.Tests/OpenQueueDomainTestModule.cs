using Volo.Abp.Modularity;

namespace OpenQueue;

[DependsOn(
    typeof(OpenQueueDomainModule),
    typeof(OpenQueueTestBaseModule)
)]
public class OpenQueueDomainTestModule : AbpModule
{

}
