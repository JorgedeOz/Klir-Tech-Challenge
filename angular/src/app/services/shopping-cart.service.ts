import { Inject, Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ShoppingCart } from '../models/shopping-cart';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class ShoppingCartService {
 
  private apiUrl: string;

  constructor(private httpClient: HttpClient,@Inject('BASE_API_URL') baseUrl: string) {
    this.apiUrl = baseUrl;
  }

  addProduct(productId:number) : Observable<any>{
    return this.httpClient.post(`${this.apiUrl}shoppingcart`,{ProductId: productId},httpOptions);
  }

  getShoppingCart() : Observable<ShoppingCart>{
    return this.httpClient.get<ShoppingCart>(`${this.apiUrl}shoppingcart`);
  }

  removeItem(producId: number) : Observable<any>{
    return this.httpClient.delete(`${this.apiUrl}shoppingcart/${producId}`);
  }

}
