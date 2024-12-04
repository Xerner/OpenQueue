using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace OpenQueue.Models.Queues;

public class Queue : FullAuditedAggregateRoot<Guid>, IMultiTenant
{
    public Guid? TenantId { get; set; }

    public required string Name { get; set; }

    public Guid UserOwnerId { get; set; }

    public IEnumerable<QueueItem> QueueItems { get; set; } = [];
}
