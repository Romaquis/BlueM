using BlueModasApi.Models;
using Microsoft.EntityFrameworkCore;
using BlueModasApi.Data.Maps;

namespace BlueModasApi.Data {
    public class StoreDataContext: DbContext{
        public DbSet<Product> Products{get; set;}
        public DbSet<Account> Accounts{get; set;}
        public DbSet<Sale> Sales{get; set;}
        public DbSet<Payment> Payments {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(@"Server=.;Database=bluemodas;User Id=sa;Password=180788");
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.ApplyConfiguration(new ProductMap());
            builder.ApplyConfiguration(new AccountMap());
            builder.ApplyConfiguration(new PaymentMap());
            builder.ApplyConfiguration(new SaleMap());
        }
    }
}
