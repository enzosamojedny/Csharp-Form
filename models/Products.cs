using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coderhouse_MAIN.models
{
    public partial class Products
    {
        public int ID {  get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public double BuyPrice { get; set; }
        public double SellPrice { get; set; }

        public decimal Stock {  get; set; }

        public decimal TotalProduct {  get; set; }

        public string Category {  get; set; }
        public int UsersID { get; set; }
        //public decimal? Cost { get; set; }
        public virtual Users IdUserNavigation { get; set; } = null!;
        public virtual ICollection<ProductSold> ProductSold { get; set; }


    }
}
