using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldApp.Model
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {            
            string connectionString = @"
			    Data Source=HOME\SQLEXPRESS;
			    Initial Catalog=Countries_db;
			    Integrated Security=SSPI;
			    Timeout=5;
                TrustServerCertificate=true;
		    ";
            options.UseSqlServer(connectionString);
        }
    }
}
