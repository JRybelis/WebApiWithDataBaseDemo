using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiWithDataBaseDemo.Models;

namespace WebApiWithDataBaseDemo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ShopItem> ShopItems { get; set; }
        public DbSet<Shop> Shops { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (!Shops.Any())
            {
                Shops.Add(new Shop()
                {
                    Name = "DefaultShop"
                });
                SaveChanges();
            }
        }
    }
}
