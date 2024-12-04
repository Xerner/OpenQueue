using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace OpenQueue.Queues;

public class QueueItemDto : FullAuditedEntityDto<Guid>
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public int Quantity { get; set; }
    public string Sender { get; set; } = "";
    public float Price { get; set; }
    public string Note { get; set; } = "";
}