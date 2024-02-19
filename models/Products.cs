using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coderhouse_MAIN.models
{
    public partial class Products
    {
        public int Id {  get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public double BuyPrice { get; set; }
        public double SellPrice { get; set; }

        public decimal Stock {  get; set; }

        public decimal TotalProduct {  get; set; }

        public string Category {  get; set; }

        static Products()
        {
            Products s = new Products();
        }

    }
}
