using Alice.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Data.Context
{
    public class LuxuryContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Tour> Tours { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=142.93.172.93;port=3306;database=luxuryistanbul;uid=appuser;password=Xvsc3711!");
        }
    }
}
