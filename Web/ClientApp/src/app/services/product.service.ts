import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { ProductModel } from "../models/product.model";

@Injectable({
  providedIn: 'root'
})

export class ProductService {

  private productUrl = 'product';

  constructor(private httpClient: HttpClient) { }

  getProducts() {
    return this.httpClient.get<ProductModel[]>(this.productUrl)
  }
}
