using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ToyStoreExample.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
            new Category
            {
                CategoryID = 1,
                CategoryName = "Cars"
             },
            new Category
            {
                CategoryID = 2,
                CategoryName = "Boats"
             },
            new Category
            {
                CategoryID = 3,
                CategoryName = "Trucks"
             },
            new Category
            {
                CategoryID = 4,
                CategoryName = "Planes"
             },
            new Category
            {
                CategoryID = 5,
                CategoryName = "Rockets"
             },
         };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID =1,
                    ProductName = "Convertible Car",
                    Description = " This is a convertible car that goes really fast! The engine is powered by a heavy duty gas that makes it power up faster!",
                    ImagePath="carconvert.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
                },
                 new Product
                {
                    ProductID =2,
                    ProductName = "Convertible Car2",
                    Description = " This is a convertible2 car that goes really fast! The engine is powered by a heavy duty gas that makes it power up faster!",
                    ImagePath="carearly.png",
                    UnitPrice = 15.50,
                    CategoryID = 1
                },

                  new Product
                {
                    ProductID =3,
                    ProductName = "Car 3",
                    Description = " This is Car that goes really fast! The engine is powered by a heavy duty gas that makes it power up faster!",
                    ImagePath="carfast.png",
                    UnitPrice = 222.50,
                    CategoryID = 2
                },
                     new Product
                {
                    ProductID = 4,
                    ProductName = "Plane 1",
                    Description = " This is a Plane that goes really fast! The engine is powered by a heavy duty gas that makes it power up faster!",
                    ImagePath="planeace.png",
                    UnitPrice = 22.50,
                    CategoryID = 2
                },
                           new Product
                {
                    ProductID = 5,
                    ProductName = "Plane 2",
                    Description = " This is a Plane that goes really fast! The engine is powered by a heavy duty gas that makes it power up faster!",
                    ImagePath="planeglider.png",
                    UnitPrice = 12.50,
                    CategoryID = 2
                },
                                 new Product
                {
                    ProductID = 6,
                    ProductName = "Plane 3",
                    Description = " This is a Plane that Made out of Paper! This Does not have a  engine!",
                    ImagePath="planepaper.png",
                    UnitPrice = 22.50,
                    CategoryID = 2
                },
                  new Product
                {
                    ProductID = 7,
                    ProductName = "Truck 1",
                    Description = " This is a Truck that goes really fast! The engine is powered by a heavy duty gas that makes it power up faster!",
                    ImagePath="truckbig.png",
                    UnitPrice = 10.50,
                    CategoryID = 3
                },
                    new Product
                {
                    ProductID = 8,
                    ProductName = "Truck 2",
                    Description = " This is a Plane that goes really fast! The engine is powered by a heavy duty gas that makes it power up faster!",
                    ImagePath="truckearly.png",
                    UnitPrice = 20.50,
                    CategoryID = 3
                },

                      new Product
                {
                    ProductID = 9,
                    ProductName = "Truck 4x4",
                    Description = " This is a Plane that goes really fast! The engine is powered by a heavy duty gas that makes it power up faster!",
                    ImagePath="truckfire.png",
                    UnitPrice = 10.50,
                    CategoryID = 3
                },

                        new Product
                {
                    ProductID = 10,
                    ProductName = "Boat 1",
                    Description = " This is a Boat that goes really fast! The engine is powered by a heavy duty gas that makes it power up faster!",
                    ImagePath="boatsail.png",
                    UnitPrice = 10.50,
                    CategoryID = 4
                },
                               new Product
                {
                    ProductID = 11,
                    ProductName = "Boat 2",
                    Description = " This is a Boat2 that goes really fast! The engine is powered by a heavy duty gas that makes it power up faster!",
                    ImagePath="boatbig.png",
                    UnitPrice = 10.50,
                    CategoryID = 4
                },

                        new Product
                {
                    ProductID = 12,
                    ProductName = "Rocket",
                    Description = " This is a Rocket that goes really fast! The engine is powered by a heavy duty gas that makes it power up faster!",
                    ImagePath="rocket.png",
                    UnitPrice = 10.50,
                    CategoryID = 5
                },

                          new Product
                {
                    ProductID = 13,
                    ProductName = "Rocket Robin",
                    Description = " This is a Rocket Robin that goes really fast! The engine is powered by a heavy duty gas that makes it power up faster!",
                    ImagePath="rocket.png",
                    UnitPrice = 110.50,
                    CategoryID = 5
                },

        };
            return products;
        }
    }

}