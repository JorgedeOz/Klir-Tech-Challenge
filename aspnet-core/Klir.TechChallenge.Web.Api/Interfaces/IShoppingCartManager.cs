using KlirTechChallenge.Web.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlirTechChallenge.Web.Api.Interfaces{
    public interface IShoppingCartManager
    {
        void AddToShoppingCart(int productId);
        void RemoveFromShoppingCart(int productId);      
        ShoppingCartModel GetShoppingCart();  
    }
}