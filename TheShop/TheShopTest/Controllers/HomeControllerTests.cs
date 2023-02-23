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
    public class HomeControllerTests
    {

        [Fact]
        public void Index_Use_ProductOfTheWeeks_FromRepository()
        {
            var mockProductRepository = RepositoryMocks.GetProductRepository();

            HomeController homeController = new HomeController(mockProductRepository.Object);

            var result = homeController.Index().ViewData.Model
                    as HomeViewModel;

            Assert.NotNull(result);

            var piesOfTheWeek = result?.ProductOfTheWeek?.ToList();
            Assert.NotNull(piesOfTheWeek);
            Assert.True(piesOfTheWeek?.Count() == 3);
            Assert.Equal("Apple Pie", piesOfTheWeek?[0].Name);


        }
    }
}
