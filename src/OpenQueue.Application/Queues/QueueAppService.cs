using System;
using OpenQueue.Models.Books;
using OpenQueue.Models.Queues;
using OpenQueue.Permissions;
using OpenQueue.Queues;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace OpenQueue.Books;

public class QueueAppService :
    CrudAppService<
        Queue, //The Book entity
        QueueDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateQueueDto>, //Used to create/update a book
    IQueueAppService //implement the IBookAppService
{
    public QueueAppService(IRepository<Queue, Guid> repository)
        : base(repository)
    {
        GetPolicyName = OpenQueuePermissions.Queues.Default;
        GetListPolicyName = OpenQueuePermissions.Queues.Default;
        CreatePolicyName = OpenQueuePermissions.Queues.Create;
        UpdatePolicyName = OpenQueuePermissions.Queues.Edit;
        DeletePolicyName = OpenQueuePermissions.Queues.Delete;
    }
}