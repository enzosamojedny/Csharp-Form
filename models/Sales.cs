using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coderhouse_MAIN.models
{
    public partial class Sales
    {
        public Sales()
        {
            ProductSold = new HashSet<ProductSold>();
        }

        public int ID { get; set; }
        public string Comments { get; set; }
        public int UserID {  get; set; }
        public virtual Users IdUserNavigation { get; set; } = null!;
        public virtual ICollection<ProductSold> ProductSold { get; set; }
    }
}