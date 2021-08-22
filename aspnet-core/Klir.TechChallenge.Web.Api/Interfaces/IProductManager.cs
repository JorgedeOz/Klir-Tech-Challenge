using KlirTechChallenge.Web.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlirTechChallenge.Web.Api.Interfaces{
    public interface IProductManager{
        IEnumerable<ProductModel> GetProducts();
        ProductModel GetProductById(int id);
    }
}