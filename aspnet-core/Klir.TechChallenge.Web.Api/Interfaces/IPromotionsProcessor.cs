using KlirTechChallenge.Web.Api.Enumerations;
using KlirTechChallenge.Web.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlirTechChallenge.Web.Api.Interfaces{
    public interface IPromotionsProcessor{
        PromotionModel Process(ShoppingCartItemModel item);
    }
}