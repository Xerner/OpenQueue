using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenQueue.Models.Queues;
using OpenQueue.Configurations.Abstractions;
namespace OpenQueue.Configurations;

public class QueueItemEntityTypeConfiguration : EntityTypeConfiguration<QueueItem>
{
    public override void Configure(EntityTypeBuilder<QueueItem> builder)
    {
        ConfigureForAbp(builder, "QueueItems");
        builder.Property(x => x.Name).IsRequired().HasMaxLength(256);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(1024);
        builder.Property(x => x.Note).IsRequired().HasMaxLength(1024);
        builder.Property(x => x.Sender).IsRequired().HasMaxLength(1024);
    }
}
