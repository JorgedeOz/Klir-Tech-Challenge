import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Product } from '../models/product'
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {
  
  private apiUrl: string;

  constructor(private httpClient: HttpClient, @Inject('BASE_API_URL') baseUrl: string) { 
    this.apiUrl = baseUrl;    
  }

  public getProducts(): Observable<Product[]>{
    return this.httpClient.get<Product[]>(`${this.apiUrl}products`);
  }

}
