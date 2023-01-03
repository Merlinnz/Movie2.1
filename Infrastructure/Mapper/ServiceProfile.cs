using AutoMapper;
using Domain.Dtos;
using Domain.Entities;

namespace Infrastructure.Mapper;

public class ServiceProfile : Profile
{
    public ServiceProfile()
    {
        CreateMap<Movie, GetMovieDto>().ReverseMap();
        CreateMap<Actor, GetActorDto>().ReverseMap();
        CreateMap<Category, GetCategoryDto>().ReverseMap(); 
    }
}
