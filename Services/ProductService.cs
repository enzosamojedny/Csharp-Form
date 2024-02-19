using C__Coderhouse_MAIN.database;
using C__Coderhouse_MAIN.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coderhouse_MAIN.Services
{
    public static class ProductService
    {
        public static List<Products> GetProducts()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                List<Products> products = context.Products.ToList();
                return products;
            }
        }
    }
}
