﻿using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Models;

namespace TheShopTest.Mocks
{
    public class RepositoryMocks
    {
        public static Mock<IProductRepository> GetProductRepository()
        {
            var product = new List<Product>
            {
                new Product
                {
                    Name = "Apple Pie",
                    Price = 12.95M,
                    ShortDescription = "Our famous apple pies!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                    InStock = true,
                    IsItemOfTheWeek = true,
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                    AllergyInformation = ""
                },
                new Product
                {
                    Name = "Blueberry Cheese Cake",
                    Price = 18.95M,
                    ShortDescription = "You'll love it!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Cheese cakes"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                    InStock = true,
                    IsItemOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                    AllergyInformation = ""
                },
                new Product
                {
                    Name = "Cheese Cake",
                    Price = 18.95M,
                    ShortDescription = "Plain cheese cake. Plain pleasure.",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Cheese cakes"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                    InStock = true,
                    IsItemOfTheWeek = false,
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                    AllergyInformation = ""
                },
                new Product
                {
                    Name = "Cherry Pie",
                    Price = 15.95M,
                    ShortDescription = "A summer classic!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
                    InStock = true,
                    IsItemOfTheWeek = false,
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
                    AllergyInformation = ""
                },
                new Product
                {
                    Name = "Christmas Apple Pie",
                    Price = 13.95M,
                    ShortDescription = "Happy holidays with this pie!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Seasonal pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
                    InStock = true,
                    IsItemOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",
                    AllergyInformation = ""
                },
                new Product
                {
                    Name = "Cranberry Pie",
                    Price = 17.95M,
                    ShortDescription = "A Christmas favorite",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Seasonal pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
                    InStock = true,
                    IsItemOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg",
                    AllergyInformation = ""
                },
                new Product
                {
                    Name = "Peach Pie",
                    Price = 15.95M,
                    ShortDescription = "Sweet as peach",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
                    InStock = false,
                    IsItemOfTheWeek = false,
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg",
                    AllergyInformation = ""
                },
                new Product
                {
                    Name = "Pumpkin Pie",
                    Price = 12.95M,
                    ShortDescription = "Our Halloween favorite",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Seasonal pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                    InStock = true,
                    IsItemOfTheWeek = true,
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                    AllergyInformation = ""
                },
                new Product
                {
                    Name = "Rhubarb Pie",
                    Price = 15.95M,
                    ShortDescription = "My God, so sweet!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
                    InStock = true,
                    IsItemOfTheWeek = true,
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                    AllergyInformation = ""
                },
                new Product
                {
                    Name = "Strawberry Pie",
                    Price = 15.95M,
                    ShortDescription = "Our delicious strawberry pie!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                    InStock = true,
                    IsItemOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                    AllergyInformation = ""
                },
            };

            var mockPieRepository = new Mock<IProductRepository>();
            mockPieRepository.Setup(repo => repo.AllProducts).Returns(product);
            mockPieRepository.Setup(repo => repo.ItemsOfTheWeek).Returns(product.Where(p => p.IsItemOfTheWeek));
            mockPieRepository.Setup(repo => repo.GetItemById(It.IsAny<int>())).Returns(product[0]);
            return mockPieRepository;
        }

        public static Mock<ICategoryRepository> GetCategoryRepository()
        {
            var categories = new List<Category>
            {
                new Category()
                {
                    CategoryId = 1,
                    CategoryName = "Fruit Pies",
                    Description = "Lorem ipsum"
                },
                new Category()
                {
                    CategoryId = 2,
                    CategoryName = "Cheese cakes",
                    Description = "Lorem ipsum"
                },
                new Category()
                {
                    CategoryId = 3,
                    CategoryName = "Fruit Pies",
                    Description = "Seasonal pies"
                }
            };

            var mockCategoryRepository = new Mock<ICategoryRepository>();
            mockCategoryRepository.Setup(repo => repo.AllCategories).Returns(categories);

            return mockCategoryRepository;
        }

        private static Dictionary<string, Category>? _categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Fruit pies" },
                        new Category { CategoryName = "Cheese cakes" },
                        new Category { CategoryName = "Seasonal pies" }
                    };

                    _categories = new Dictionary<string, Category>();

                    foreach (var genre in genresList)
                    {
                        _categories.Add(genre.CategoryName, genre);
                    }
                }

                return _categories;
            }
        }
    }
}
