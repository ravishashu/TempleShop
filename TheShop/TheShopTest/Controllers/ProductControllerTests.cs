using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Controllers;
using TheShop.ViewModels;
using TheShopTest.Mocks;
using Xunit;

namespace TheShopTest.Controllers
{
    public class ProductControllerTests
    {
        [Fact]
        public void List_EmptyCategory_ReturnsAllProducts()
        {
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var mockProductRepository = RepositoryMocks.GetProductRepository();

            var productController = new ProductController(mockProductRepository.Object, mockCategoryRepository.Object);

            //act
            var result = productController.List("");

            //assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var productListViewModel = Assert.IsAssignableFrom<ProductListViewModel>(viewResult.ViewData.Model);
            Assert.Equal(10, productListViewModel.Product.Count());
        }
    }
}
