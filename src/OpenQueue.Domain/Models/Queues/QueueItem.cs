using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace OpenQueue.Models.Queues;

public class QueueItem : FullAuditedEntity<Guid>, IMultiTenant
{
    public Guid? TenantId { get; set; }
    public Guid QueueId { get; set; }
    public required string Name { get; set; }
    public string Description { get; set; } = "";
    public int Quantity { get; set; }
    public required string Sender { get; set; }
    public float Price { get; set; }
    public string Note { get; set; } = "";
}
