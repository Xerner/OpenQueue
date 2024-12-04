using OpenQueue.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace OpenQueue.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OpenQueueEntityFrameworkCoreModule),
    typeof(OpenQueueApplicationContractsModule)
)]
public class OpenQueueDbMigratorModule : AbpModule
{
}
