using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenQueue.Models.Queues;
using OpenQueue.Configurations.Abstractions;
namespace OpenQueue.Configurations;

public class QueueEntityTypeConfiguration : EntityTypeConfiguration<Queue>
{
    public override void Configure(EntityTypeBuilder<Queue> builder)
    {
        base.ConfigureForAbp(builder, "Queues");
        builder.Property(x => x.Name).IsRequired().HasMaxLength(256);
    }
}
