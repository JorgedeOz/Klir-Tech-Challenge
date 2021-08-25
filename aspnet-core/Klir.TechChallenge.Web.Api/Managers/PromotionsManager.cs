using KlirTechChallenge.Web.Api.Enumerations;
using KlirTechChallenge.Web.Api.Interfaces;
using KlirTechChallenge.Web.Api.Managers.Promotions;
using KlirTechChallenge.Web.Api.Models;
using System.Collections.Generic;

namespace KlirTechChallenge.Web.Api.Managers
{
    public class PromotionsManager : IPromotionsManager{

        private List<IPromotionsProcessor> promotionsProcessors = new List<IPromotionsProcessor>();

        public PromotionsManager(){
            promotionsProcessors.Add(new ManagerPromotionGet3For10Euro());
            promotionsProcessors.Add(new ManagerPromotionBuy1Get1Free());
        }

        public void ProcessPromotions(ShoppingCartItemModel item)
        {    
            foreach(var promotionProcessor in promotionsProcessors){
                item.Promotion = promotionProcessor.Process(item);
                if(item.Promotion.PromotionType != PromotionEnum.None){
                    item.Total = item.Promotion.Total;
                    break;
                }
            }
        }
    }
}