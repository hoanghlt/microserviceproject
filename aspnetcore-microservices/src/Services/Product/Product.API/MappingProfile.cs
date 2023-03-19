using AutoMapper;
using Shared.DTOs.Product;
using Infrastructure.Mappings;

namespace Product.API;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Entities.Product, ProductDto>();
        CreateMap<Entities.Product, ProductDto>();
        CreateMap<Entities.Product, ProductDto>().IgnoreAllNonExisting();
    }
}