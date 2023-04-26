using AutoMapper;
using Infotech.Services.ProductAPI.Models;
using Infotech.Services.ProductAPI.Models.Dto;

namespace Infotech.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;
        }
    }
}
