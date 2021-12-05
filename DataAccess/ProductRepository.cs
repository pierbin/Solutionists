using Domain;
using Domain.Interface;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { ProductId = 1, Name = "Nintendo Switch Commuter Case", Price=49.99m, Stock=59, Image="assets/images/switchcase.jpg"},
                new Product { ProductId = 2, Name = "Nintendo Switch Neon Console", Price=549.99m, Stock=69, Image="assets/images/switch.jpg"},
                new Product { ProductId = 3, Name = "Nintendo Switch Joy-Con", Price=139.99m, Stock=79, Image="assets/images/joycontroller.jpg"},
                new Product { ProductId = 4, Name = "Nintendo Switch Wheel", Price=29.99m, Stock=89, Image="assets/images/wheel.jpg"}
            };
        }
    }
}
