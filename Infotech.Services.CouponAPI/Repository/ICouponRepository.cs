using Infotech.Services.CouponAPI.Models.Dto;

namespace Infotech.Services.CouponAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCouponByCode(string couponCode);
    }
}
