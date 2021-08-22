using KlirTechChallenge.Web.Api.Enumerations;
using KlirTechChallenge.Web.Api.Interfaces;
using KlirTechChallenge.Web.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace KlirTechChallenge.Web.Api.Managers.Promotions
{
    public class ManagerPromotionGet3For10Euro : IPromotionsProcessor
    {
        public PromotionModel Process(ShoppingCartItemModel item)
        {
            var promotionModel = new PromotionModel(){
                PromotionType = PromotionEnum.None
            };
            if(item.Quantity >= 3){
                promotionModel.PromotionName = "3 for 10 Euro";
                promotionModel.PromotionType = PromotionEnum.Get3For10Euro;
                promotionModel.TimesApplied = item.Quantity / 3;
                promotionModel.Total = 0;
                for(var x = 0; x < promotionModel.TimesApplied;x++){
                    promotionModel.Total += 10;
                }                
            }
            return promotionModel;
        }
    }
}