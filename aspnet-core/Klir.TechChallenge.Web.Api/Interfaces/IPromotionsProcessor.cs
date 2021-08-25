using KlirTechChallenge.Web.Api.Models;

namespace KlirTechChallenge.Web.Api.Interfaces
{
    public interface IPromotionsProcessor{
        PromotionModel Process(ShoppingCartItemModel item);
    }
}