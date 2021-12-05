using Domain;
using Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Web.Controllers;
using Xunit;

namespace Test
{
    public class ProductControllerTest
    {
        private readonly ProductController _productController;
        private readonly Mock<IProductService> _productServiceMock = new Mock<IProductService>();
        private IList<Product> _products;

        public ProductControllerTest()
        {
            _productController = new ProductController(_productServiceMock.Object);
            _products = new List<Product>
            {
                new Product { ProductId = 1, Name = "Nintendo Switch Commuter Case", Price=49.99m, Stock=59, Image="assets/images/switchcase.jpg"},
                new Product { ProductId = 2, Name = "Nintendo Switch Neon Console", Price=549.99m, Stock=69, Image="assets/images/switch.jpg"},
                new Product { ProductId = 3, Name = "Nintendo Switch Joy-Con", Price=139.99m, Stock=79, Image="assets/images/joycontroller.jpg"},
                new Product { ProductId = 4, Name = "Nintendo Switch Wheel", Price=29.99m, Stock=89, Image="assets/images/wheel.jpg"}
            };
        }

        [Fact]
        public void GetProducts_ShouldReturnProducts_WhenProductsExists()
        {
            //Arrange
            _productServiceMock.Setup(p => p.GetProducts()).Returns(_products);

            //Act
            var result = _productController.GetProducts() as OkObjectResult;
            var products = result.Value as ICollection<Product>;

            //Assert
            Assert.Equal(_products.Count, products.Count);
        }

        [Fact]
        public void GetProducts_ShouldReturnBadRequests_WhenProductsNotExists()
        {
            //Arrange
            _productServiceMock.Setup(p => p.GetProducts()).Returns(() => null);

            //Act
            var result = _productController.GetProducts();

            //Assert
            Assert.IsType<BadRequestResult>(result);
        }
    }
}
