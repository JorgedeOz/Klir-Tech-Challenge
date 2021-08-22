using KlirTechChallenge.Web.Api.Interfaces;
using KlirTechChallenge.Web.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace KlirTechChallenge.Web.Api.Managers
{
    public class ProductsManager : IProductManager{
        private List<ProductModel> products = new List<ProductModel>();
        public ProductsManager(){
            products.Add(new ProductModel(){
                Id = 1,
                Name = "Product A",
                Price = 20
            });
            products.Add(new ProductModel(){
                Id = 2,
                Name = "Product B",
                Price = 4
            });
            products.Add(new ProductModel(){
                Id = 3,
                Name = "Product C",
                Price = 2
            });
            products.Add(new ProductModel(){
                Id = 4,
                Name = "Product D",
                Price = 4
            });
        }

        public ProductModel GetProductById(int id)
        {
            return products.Where(p => p.Id == id).FirstOrDefault();
        }

        public IEnumerable<ProductModel> GetProducts()
        {
            return products;
        }
    }
}