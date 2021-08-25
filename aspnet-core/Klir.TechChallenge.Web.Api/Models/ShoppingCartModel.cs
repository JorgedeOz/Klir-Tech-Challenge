using System.Collections.Generic;

namespace KlirTechChallenge.Web.Api.Models
{
    public class ShoppingCartModel{
        public List<ShoppingCartItemModel> Items { get; set; }
        public float Total { get; set; }
    }
}