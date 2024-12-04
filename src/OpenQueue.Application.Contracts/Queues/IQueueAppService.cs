using OpenQueue.Queues;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace OpenQueue.Queues;

public interface IQueueAppService :
    ICrudAppService< //Defines CRUD methods
        QueueDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateQueueDto> //Used to create/update a book
{

}