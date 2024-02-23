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
            ProductsSold = new HashSet<Sales>();
        }
        private string _id;
        private string _comments;
        private string _userId;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }

        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public ICollection<Sales> ProductsSold { get; set; }
        public Sales(string id, string comments, string userId)
        {
            _id = id;
            _comments = comments;
            _userId = userId;
            ProductsSold = new HashSet<Sales>();
        }
    }
}