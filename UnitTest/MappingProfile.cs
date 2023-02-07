using AutoMapper;
using Application.Models;
using Domain.Entities;

namespace UnitTest
{
    public class MyMappingProfile : Profile
    {
        public MyMappingProfile()
        {
            CreateMap<Todo, TodoDto>();
            CreateMap<TodoDto, Todo>();
        }
    }
}
