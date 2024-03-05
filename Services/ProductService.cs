using C__Coderhouse_MAIN.database;
using C__Coderhouse_MAIN.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coderhouse_MAIN.Services
{
    public static class ProductService
    {
        public static bool AddProduct(Products product)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                if (product != null)
                {
                    context.Products.Add(product); //ERROR HERE
                }
                context.SaveChanges();
                return true;
            }
        }
        public static List<Products> GetProducts()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                List<Products> products = context.Products.ToList();
                return products;
            }
        }
        
        public static bool DeleteProductByID(int productID)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                Products productToDelete = context.Products.Include(p=>p.ProductSold).Where(p => p.ID == productID).FirstOrDefault();
                if (productToDelete is not null)
                {
                    context.Products.Remove(productToDelete);
                    context.SaveChanges();
                    return true;
                }
            }
            return false;
        }
    }
}
