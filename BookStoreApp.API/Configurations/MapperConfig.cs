using AutoMapper;
using BookStoreApp.API.Models.Author;
using BookStoreApp.API.Data; 

namespace BookStoreApp.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto,Author>().ReverseMap();
               
        }
    }
}
