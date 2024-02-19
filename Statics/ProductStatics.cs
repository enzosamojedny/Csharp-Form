using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Coderhouse_MAIN.models;

namespace C__Coderhouse_MAIN.Statics
{
    internal class ProductStatics
    {
        public static Products GetProductByID(int productId)
        {

            return new Products { Id = productId, Name = "Product Name", Description = "Product Description", BuyPrice = 10.0, SellPrice = 15.0, Stock = 100, TotalProduct = 1000, Category = "Category" };
        }

        public static List<Products> GetProducts()
        {

            return new List<Products>
            {
                new Products { Id = 1, Name = "Product 1", Description = "Description 1", BuyPrice = 10.0, SellPrice = 15.0, Stock = 100, TotalProduct = 1000, Category = "Category 1" },
                new Products { Id = 2, Name = "Product 2", Description = "Description 2", BuyPrice = 20.0, SellPrice = 25.0, Stock = 200, TotalProduct = 2000, Category = "Category 2" },
            };
        }

        public static void CreateProducts(Products product)
        {
            Console.WriteLine("Product created successfully.");
        }

        public static void UpdateProduct(Products product)
        {
            Console.WriteLine($"Product with ID {product.Id} modified successfully.");
        }

        public static void DeleteProduct(int productId)
        {
            Console.WriteLine($"Product with ID {productId} deleted successfully.");
        }
    }
}
