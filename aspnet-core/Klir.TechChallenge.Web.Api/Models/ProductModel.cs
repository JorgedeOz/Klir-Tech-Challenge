using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlirTechChallenge.Web.Api.Models
{
    public class ProductModel{
        public int Id { get; set; }
        public string Name { get; set; } 
        public float Price { get; set; }
    }
}