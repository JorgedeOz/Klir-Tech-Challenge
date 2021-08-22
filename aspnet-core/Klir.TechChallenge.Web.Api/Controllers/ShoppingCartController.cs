using System;
using System.Net;
using KlirTechChallenge.Web.Api.Dtos;
using KlirTechChallenge.Web.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KlirTechChallenge.Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppingCartController : ControllerBase
    {   
        private IShoppingCartManager _shoppingCartManager;
        
        public ShoppingCartController(IShoppingCartManager shoppingCartManager){
            _shoppingCartManager = shoppingCartManager;
        }

        [HttpGet]
        public IActionResult GetShoppingCart(){
            try{                
                return Ok(_shoppingCartManager.GetShoppingCart());
            }catch(Exception ex){
                return StatusCode((int)HttpStatusCode.InternalServerError,ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult AddItem([FromBody] ProductDto product){
            try{
                _shoppingCartManager.AddToShoppingCart(product.ProductId);
                return Ok();
            }catch(Exception ex){
                return StatusCode((int)HttpStatusCode.InternalServerError,ex.ToString());
            }
        }

        [HttpDelete("{productId}")]
        public IActionResult RemoveItem(int productId){
            try{
                _shoppingCartManager.RemoveFromShoppingCart(productId);
                return Ok();
            }catch(Exception ex){
                return StatusCode((int)HttpStatusCode.InternalServerError,ex.ToString());
            }
        }
    }
}