using System.Diagnostics;

namespace PakizaSoftwareWorks.Models
{
    public class DbSeeder
    {
        private readonly ProductDbContext db;
        public DbSeeder(ProductDbContext db)
        {
            this.db = db;
        }
        public async Task SeedAsync()
        {
            if (!await db.Database.CanConnectAsync())
            {
                await db.Database.EnsureCreatedAsync();

            }
            if (!db.Customers.Any())
            {
                await db.Customers.AddRangeAsync(new Customer[]
                {
                        new Customer {CustomerName="Murad",Phone="0156xxxxxxx",Address="mirpur-11" },
                        new Customer {CustomerName="Sazzad",Phone="0176xxxxxxx",Address="ECB"},
                }) ;
                await db.Products.AddRangeAsync(new Product[]
                {
                        new Product {ProductName="BooK",UnitPrice=200.00M},
                        new Product {ProductName="Pen",UnitPrice=20.00M},
                        new Product {ProductName="Calculator",UnitPrice=700.00M},
                        new Product {ProductName="Sharpner",UnitPrice=10.00M},
                        new Product {ProductName="Eraser",UnitPrice=12.00M},

                });
                await db.Orders.AddRangeAsync(new Order[]
              {
                     new Order{ OrderDate=DateTime.Now, CustomerId=2}
              });

                await db.SaveChangesAsync();
            }


        }
    }


}
