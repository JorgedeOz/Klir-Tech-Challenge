import { Component, OnInit } from '@angular/core';
import { ShoppingCartService } from  '../../services/shopping-cart.service'
import { Product } from '../../models/product';
import { ProductsService } from '../../services/products.service'
import { ShoppingCart } from 'src/app/models/shopping-cart';

@Component({
  selector: 'app-shopping-cart',
  templateUrl: './shopping-cart.component.html',
})
export class ShoppingCartComponent implements OnInit{

  showProducts: boolean = false;
  showHideProducts: string = "Show produtcs"
  products: Product[] = [];
  shoppingCart: ShoppingCart = {
    items: [],
    total: 0
  };

  constructor(private productsService: ProductsService, private shoppingCartService: ShoppingCartService){}

  ngOnInit(){
    this.productsService.getProducts().subscribe((data) => {
      this.products = data;
      this.getShoppingCart();
    });
  }

  toggleProducts(){
    this.showProducts = !this.showProducts;
    if(!this.showProducts) this.showHideProducts = "Show produtcs";
    else this.showHideProducts = "Hide produtcs";
  }

  addToShoppingCart(item: Product){    
    this.shoppingCartService.addProduct(item.id).subscribe(()=>{
      this.getShoppingCart();
    });
  }

  getShoppingCart(){
    this.shoppingCartService.getShoppingCart().subscribe((data) => {
      this.shoppingCart = data;
    });
  }

  getProduct(id: number){
    return this.products.find(p => p.id == id);
  }

  removeItem(producId:number){
    this.shoppingCartService.removeItem(producId).subscribe(()=>{
      this.getShoppingCart();
    });
  }
}
