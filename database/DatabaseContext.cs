using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace C__Coderhouse_MAIN.database
{
    public class DatabaseContext : DbContext
    {
        public virtual DbSet<models.Products> Products { get; set; }

        public virtual DbSet<models.Users> Users { get; set; }

        public virtual DbSet<models.Sales> Sales { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Server=.; Database=CodeDB; Trusted_Connection=True;TrustServerCertificate=true;");
        }
    }
}
