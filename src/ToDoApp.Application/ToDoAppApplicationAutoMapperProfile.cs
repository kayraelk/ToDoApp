using AutoMapper;

namespace ToDoApp;

public class ToDoAppApplicationAutoMapperProfile : Profile
{
    public ToDoAppApplicationAutoMapperProfile()
    {
       CreateMap<ToDoItem, ToDoItemDto>();
    }
}
