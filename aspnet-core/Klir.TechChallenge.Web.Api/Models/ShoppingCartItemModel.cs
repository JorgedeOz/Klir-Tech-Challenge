using KlirTechChallenge.Web.Api.Enumerations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlirTechChallenge.Web.Api.Models
{
    public class ShoppingCartItemModel{
        public int ProductId { get; set; }
        public int Quantity { get; set; }        
        public float Total { get; set; }
        public PromotionModel Promotion { get; set; }
    }
}