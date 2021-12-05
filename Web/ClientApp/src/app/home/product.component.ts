import { Component } from '@angular/core';
import { ProductModel } from '../models/product.model';
import { ProductService } from '../services/product.service';

@Component({
  selector: 'app-home',
  templateUrl: './product.component.html',
})
export class HomeComponent {
  products: ProductModel[] = [];

  constructor(private productService: ProductService) { }

  getProducts(): void {
    this.productService.getProducts()
      .subscribe(products => {
        this.products = products;
      }, error => console.error(error));
  }

  ngOnInit(): void {
    this.getProducts();
  }
}
