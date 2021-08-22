using KlirTechChallenge.Web.Api.Enumerations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlirTechChallenge.Web.Api.Models
{
    public class PromotionModel{
        public string PromotionName { get; set; }
        public PromotionEnum PromotionType { get; set; }
        public int TimesApplied { get; set; } 
        public float Total { get; set; }
    }
}