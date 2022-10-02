using System.Diagnostics.CodeAnalysis;
using AutoMapper;
using Internship.Contracts.Entity;
using Internship.Domain.Entity;
using Internship.Service.Entity;

namespace Internship
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Author, AuthorModel>();
            CreateMap<Photo, PhotoModel>().ReverseMap();
            CreateMap<Text, TextModel>().ReverseMap();
            CreateMap<PhotoModel, IPhoto>().ReverseMap();
        }
    }
}
