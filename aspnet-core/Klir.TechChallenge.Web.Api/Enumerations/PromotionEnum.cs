using KlirTechChallenge.Web.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlirTechChallenge.Web.Api.Enumerations{
    public enum PromotionEnum{
        None,
        Buy1Get1Free,
        Get3For10Euro
    }
}