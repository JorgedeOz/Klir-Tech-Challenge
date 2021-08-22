using KlirTechChallenge.Web.Api.Interfaces;
using KlirTechChallenge.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KlirTechChallenge.Web.Api.Managers
{
    public class ShoppingCartManager : IShoppingCartManager{
        
        private ShoppingCartModel _shoppingCartModel;        
        private IProductManager _productManager;
        private IPromotionsManager _promotionsManager;

        public ShoppingCartManager(IProductManager productManager, IPromotionsManager promotionsManager){
            _productManager = productManager;
            _promotionsManager = promotionsManager;
            _shoppingCartModel = new ShoppingCartModel(){
                Items = new List<ShoppingCartItemModel>(),
                Total = 0
            };
        }        

        public ShoppingCartModel GetShoppingCart()
        {
            _shoppingCartModel.Total = 0;
            foreach(var item in _shoppingCartModel.Items){                
                _shoppingCartModel.Total += item.Total;
            }
            return _shoppingCartModel;
        }

        public void AddToShoppingCart(int productId)
        {
            var isNew = true;
            var product = _productManager.GetProductById(productId);
            if(product == null) throw new Exception($"Product with id {productId} was not found");
            var item = _shoppingCartModel.Items.Where(sc => sc.ProductId == productId).FirstOrDefault();            
            if(item == null){
                item = new ShoppingCartItemModel(){
                    ProductId = product.Id,
                    Quantity = 1,
                    Total = product.Price
                };
            }else{
                isNew = false;
                item.Quantity++;
                item.Total = product.Price * item.Quantity;
            }            
            if(isNew) _shoppingCartModel.Items.Add(item);
            _promotionsManager.ProcessPromotions(item);
        }       

        public void RemoveFromShoppingCart(int productId){
            var item = _shoppingCartModel.Items.Where(sc => sc.ProductId == productId).FirstOrDefault();
            if(item == null) throw new Exception($"Item with product id {productId} was not found");            
            item.Quantity--;
            if(item.Quantity == 0) {
                _shoppingCartModel.Items.Remove(item);
            }else{                
                var product = _productManager.GetProductById(productId);
                item.Total = product.Price * item.Quantity;
                _promotionsManager.ProcessPromotions(item);
            }            
        }        
    }
}