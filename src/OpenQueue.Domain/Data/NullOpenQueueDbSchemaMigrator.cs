using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace OpenQueue.Data;

/* This is used if database provider does't define
 * IOpenQueueDbSchemaMigrator implementation.
 */
public class NullOpenQueueDbSchemaMigrator : IOpenQueueDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
