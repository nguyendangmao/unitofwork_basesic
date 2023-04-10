using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UnitOfWork_PhamTruong.DTOs.ProductDto;
using UnitOfWork_PhamTruong.Entities;

namespace UnitOfWork_PhamTruong.Automap
{
    public class mapper:Profile
    {
        public mapper()
        {
            CreateMap<Product, productDto>()
                .ForMember(dto => dto.IdProduct, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dto => dto.NameProduct, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dto => dto.PriceProduct, opt => opt.MapFrom(src => src.Price))
                .ReverseMap();
        }
    }
}
