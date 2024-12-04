using Volo.Abp.Modularity;

namespace OpenQueue;

[DependsOn(
    typeof(OpenQueueApplicationModule),
    typeof(OpenQueueDomainTestModule)
)]
public class OpenQueueApplicationTestModule : AbpModule
{

}
