using AutoMapper;
using System;

namespace Tvedc.Infrastructure
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Entities.File, Dtos.FileDto>();
            CreateMap<Entities.Permission, Dtos.PermissionDto>();
            CreateMap<Entities.Category, Dtos.CategoryDto>();
            CreateMap<Entities.Auction, Dtos.AuctionDto>();
            CreateMap<Entities.Tender, Dtos.TenderDto>();
            CreateMap<Entities.Menu, Dtos.MenuDto>();
        }
    }
}
