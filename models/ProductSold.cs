using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coderhouse_MAIN.models
{
    public partial class ProductSold
    {
        public int ID { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public int ProductID { get; set; }
        public int SaleID { get; set; }

        public virtual Products IdProductNavigation { get; set; } = null!;
        public virtual Sales IdSaleNavigation { get; set; } = null!;
    }
}
