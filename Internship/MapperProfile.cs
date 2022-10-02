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
            CreateMap<Photo, PhotoModel>()
             .ForMember(p => p.Id, o => o.MapFrom(s => s.Id))
             .ForMember(p => p.Name, o => o.MapFrom(s => s.Name))
             .ForMember(p => p.Link, o => o.MapFrom(s => s.Link))
             .ForMember(p => p.DateOfCreation, o => o.MapFrom(s => s.DateOfCreation))
             .ForMember(p => p.Author, o => o.MapFrom(s => s.Author))
             .ForMember(p => p.AuthorId, o => o.MapFrom(s => s.AuthorId))
             .ForMember(p => p.Coast, o => o.MapFrom(s => s.Coast))
             .ForMember(p => p.NumberOfSales, o => o.MapFrom(s => s.NumberOfSales))
             .ForMember(p => p.Raiting, o => o.MapFrom(s => s.AmountOfRaiting / s.NumberOfRaiting))
             .ForMember(p => p.OriginalSize, o => o.MapFrom(s => s.OriginalSize));

            CreateMap<PhotoModel, Photo>()
            .ForMember(p => p.Id, o => o.MapFrom(s => s.Id))
            .ForMember(p => p.Name, o => o.MapFrom(s => s.Name))
            .ForMember(p => p.Link, o => o.MapFrom(s => s.Link))
            .ForMember(p => p.DateOfCreation, o => o.MapFrom(s => s.DateOfCreation))
            .ForMember(p => p.Author, o => o.MapFrom(s => s.Author))
            .ForMember(p => p.AuthorId, o => o.MapFrom(s => s.AuthorId))
            .ForMember(p => p.Coast, o => o.MapFrom(s => s.Coast))
            .ForMember(p => p.NumberOfSales, o => o.MapFrom(s => s.NumberOfSales))
            .ForMember(p => p.AmountOfRaiting, o => o.Ignore())
            .ForMember(p => p.NumberOfRaiting, o => o.Ignore())
            .ForMember(p => p.OriginalSize, o => o.MapFrom(s => s.OriginalSize))
            .ReverseMap();
            CreateMap<Text, TextModel>().ReverseMap();
            CreateMap<PhotoModel, IPhoto>().ReverseMap();
        }
    }
}
