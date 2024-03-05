using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coderhouse_MAIN.models
{
    public partial class Users
    {
        public Users() {
            Products = new HashSet<Products>();
            Sales = new HashSet<Sales>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName {  get; set; }
        public string Username {  get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Products> Products { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }

        public static implicit operator Users(Products v)
        {
            throw new NotImplementedException();
        }
    }
}
