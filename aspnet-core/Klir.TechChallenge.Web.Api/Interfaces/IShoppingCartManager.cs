using KlirTechChallenge.Web.Api.Models;

namespace KlirTechChallenge.Web.Api.Interfaces
{
    public interface IShoppingCartManager
    {
        void AddToShoppingCart(int productId);
        void RemoveFromShoppingCart(int productId);      
        ShoppingCartModel GetShoppingCart();  
    }
}