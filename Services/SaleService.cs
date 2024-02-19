using C__Coderhouse_MAIN.database;
using C__Coderhouse_MAIN.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coderhouse_MAIN.Services
{
    public static class SaleService
    {
        public static List<Sales> GetSales()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                List<Sales> sales = context.Sales.ToList();
                return sales;
            }
        }
    }
}
