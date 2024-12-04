using AutoMapper;
using OpenQueue.Books;
using OpenQueue.Models.Books;

namespace OpenQueue;

public class OpenQueueApplicationAutoMapperProfile : Profile
{
    public OpenQueueApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
