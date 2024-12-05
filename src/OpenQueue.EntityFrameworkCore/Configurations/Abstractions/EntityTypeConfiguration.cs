using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace OpenQueue.Configurations.Abstractions;

public abstract class EntityTypeConfiguration<T> : IEntityTypeConfiguration<T> where T : class
{
    public abstract void Configure(EntityTypeBuilder<T> builder);

    public virtual void ConfigureForAbp(EntityTypeBuilder<T> builder)
    {
        builder.ConfigureByConvention(); //auto configure for the base class props
    }

    public virtual void ConfigureForAbp(EntityTypeBuilder<T> builder, string tableName, string? schemaName = OpenQueueConsts.DbSchema)
    {
        builder.ToTable(OpenQueueConsts.DbTablePrefix + tableName, schemaName);
        ConfigureForAbp(builder);
    }
}
