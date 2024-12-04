using System.Threading.Tasks;

namespace OpenQueue.Data;

public interface IOpenQueueDbSchemaMigrator
{
    Task MigrateAsync();
}
