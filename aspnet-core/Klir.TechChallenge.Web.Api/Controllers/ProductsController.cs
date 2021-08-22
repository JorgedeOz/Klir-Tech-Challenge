using System;
using System.Net;
using KlirTechChallenge.Web.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KlirTechChallenge.Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private IProductManager _productManager;            
        public ProductsController(IProductManager productManager){
            _productManager = productManager;
        }

        [HttpGet]
        public IActionResult GetProducts(){
            try{
                return Ok(_productManager.GetProducts());
            }catch(Exception ex){
                return StatusCode((int)HttpStatusCode.InternalServerError,ex.ToString());
            }
            
        }

    }
}