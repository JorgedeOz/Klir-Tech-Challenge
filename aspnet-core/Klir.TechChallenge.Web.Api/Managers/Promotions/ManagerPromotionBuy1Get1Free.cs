using KlirTechChallenge.Web.Api.Enumerations;
using KlirTechChallenge.Web.Api.Interfaces;
using KlirTechChallenge.Web.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace KlirTechChallenge.Web.Api.Managers.Promotions
{
    public class ManagerPromotionBuy1Get1Free : IPromotionsProcessor
    {
        public PromotionModel Process(ShoppingCartItemModel item)
        {
            var promotionModel = new PromotionModel(){
                PromotionType = PromotionEnum.None
            };
            if(item.Quantity >= 2){
                promotionModel.PromotionName = "Buy 1 Get 1 Free";
                promotionModel.PromotionType = PromotionEnum.Buy1Get1Free;
                promotionModel.TimesApplied = item.Quantity / 2;
                promotionModel.Total = item.Total;
                for(var x = 0; x < promotionModel.TimesApplied;x++){
                    promotionModel.Total /= 2;
                }
            }
            return promotionModel;
        }
    }
}