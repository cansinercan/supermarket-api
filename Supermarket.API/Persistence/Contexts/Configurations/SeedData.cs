using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Persistence.Contexts.Configurations
{
    public class SeedData
    {
        public static async Task Seed(AppDbContext context)
        {
            var categories = new List<Category>
            {
                new Category
                {
                    Id = 100, 
                    Name = "Fruits and Vegetables"
                },
                new Category
                {
                    Id = 101, 
                    Name = "Dairy"
                }
            };

            var products = new List<Product>
            {
                new Product
                {
                    //Id = 100,
                    Name = "Apple",
                    QuantityInPackage = 1,
                    UnitOfMeasurement = EUnitOfMeasurement.Unity,
                    CategoryId = 100
                },
                new Product
                {
                    //Id = 101,
                    Name = "Milk",
                    QuantityInPackage = 2,
                    UnitOfMeasurement = EUnitOfMeasurement.Liter,
                    CategoryId = 101,
                }
            };

            context.Categories.AddRange(categories);
            context.Products.AddRange(products);

            await context.SaveChangesAsync();
        }
    }
}
