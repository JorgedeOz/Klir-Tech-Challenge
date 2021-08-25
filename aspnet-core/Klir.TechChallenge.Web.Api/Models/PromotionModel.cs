using KlirTechChallenge.Web.Api.Enumerations;

namespace KlirTechChallenge.Web.Api.Models
{
    public class PromotionModel{
        public string PromotionName { get; set; }
        public PromotionEnum PromotionType { get; set; }
        public int TimesApplied { get; set; } 
        public float Total { get; set; }
    }
}