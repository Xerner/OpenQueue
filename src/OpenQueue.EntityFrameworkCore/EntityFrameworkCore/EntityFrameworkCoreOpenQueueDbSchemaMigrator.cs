using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OpenQueue.Data;
using Volo.Abp.DependencyInjection;

namespace OpenQueue.EntityFrameworkCore;

public class EntityFrameworkCoreOpenQueueDbSchemaMigrator
    : IOpenQueueDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreOpenQueueDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the OpenQueueDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<OpenQueueDbContext>()
            .Database
            .MigrateAsync();
    }
}
