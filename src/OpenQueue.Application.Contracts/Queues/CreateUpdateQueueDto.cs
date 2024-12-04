using System;
using System.ComponentModel.DataAnnotations;

namespace OpenQueue.Queues;

public class CreateUpdateQueueDto
{
    [Required]
    [StringLength(128)]
    public string Name { get; set; } = string.Empty;
    [Required]
    public Guid UserOwnerId { get; set; }
}
