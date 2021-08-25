using KlirTechChallenge.Web.Api.Models;

namespace KlirTechChallenge.Web.Api.Interfaces
{
    public interface IPromotionsManager{
        void ProcessPromotions(ShoppingCartItemModel item);
    }
}