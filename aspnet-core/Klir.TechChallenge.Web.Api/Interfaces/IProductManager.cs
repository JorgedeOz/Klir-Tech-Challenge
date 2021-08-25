using KlirTechChallenge.Web.Api.Models;
using System.Collections.Generic;

namespace KlirTechChallenge.Web.Api.Interfaces
{
    public interface IProductManager{
        IEnumerable<ProductModel> GetProducts();
        ProductModel GetProductById(int id);
    }
}