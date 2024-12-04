using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace OpenQueue.Queues;

public class QueueDto : FullAuditedEntityDto<Guid>
{
    public string Name { get; set; } = "";

    public Guid UserOwnerId { get; set; }

    public IEnumerable<QueueItemDto> QueueItems { get; set; } = [];
}