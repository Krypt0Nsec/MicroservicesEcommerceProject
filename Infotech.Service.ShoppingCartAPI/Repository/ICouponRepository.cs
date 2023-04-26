using Infotech.Service.ShoppingCartAPI.Models.Dto;

namespace Infotech.Service.ShoppingCartAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCoupon(string couponName);
    }
}
