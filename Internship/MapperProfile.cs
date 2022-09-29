using System.Diagnostics.CodeAnalysis;
using AutoMapper;
using Internship.Domain.Entity;
using Internship.Service.Entity;

namespace Internship
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Author, AuthorModel>();
            CreateMap<Photo, PhotoModel>();
            CreateMap<Text, TextModel>();
        }
    }
}
