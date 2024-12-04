using System;
using OpenQueue.Models.Books;
using OpenQueue.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace OpenQueue.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
        GetPolicyName = OpenQueuePermissions.Books.Default;
        GetListPolicyName = OpenQueuePermissions.Books.Default;
        CreatePolicyName = OpenQueuePermissions.Books.Create;
        UpdatePolicyName = OpenQueuePermissions.Books.Edit;
        DeletePolicyName = OpenQueuePermissions.Books.Delete;
    }
}