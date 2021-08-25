namespace KlirTechChallenge.Web.Api.Models
{
    public class ShoppingCartItemModel{
        public int ProductId { get; set; }
        public int Quantity { get; set; }        
        public float Total { get; set; }
        public PromotionModel Promotion { get; set; }
    }
}