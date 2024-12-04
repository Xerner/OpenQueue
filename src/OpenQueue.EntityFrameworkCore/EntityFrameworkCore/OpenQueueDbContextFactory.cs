using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace OpenQueue.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class OpenQueueDbContextFactory : IDesignTimeDbContextFactory<OpenQueueDbContext>
{
    public OpenQueueDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        OpenQueueEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<OpenQueueDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new OpenQueueDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../OpenQueue.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
