using AutoMapper;
using Infotech.Services.CouponAPI.Models;
using Infotech.Services.CouponAPI.Models.Dto;

namespace Infotech.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>().ReverseMap();
              
            });

            return mappingConfig;
        }
    }
}
