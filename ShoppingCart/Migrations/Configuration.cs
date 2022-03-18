namespace ShoppingCart.Migrations
{
    using ShoppingCart.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShoppingCart.Data.ShoppingCartContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShoppingCart.Data.ShoppingCartContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var categories = new List<Category>
            {
            new Category{Name="Áo thun"},
            new Category{Name="Áo khoác"},
            new Category{Name="Quần"},
            };

            categories.ForEach(s => context.Category.Add(s));
            context.SaveChanges();


            var products = new List<Product>
            {
            new Product{Name="Áo thun", CategoryId=1, Price=50000},
            new Product{Name="Áo ngắn tay cổ lọ",  CategoryId=1, Price=100000},
            new Product{Name="Áo dài tay",  CategoryId=1, Price=50000},
            new Product{Name="Áo gió", CategoryId=2, Price=500000},
            new Product{Name="Áo thu đông", CategoryId=2, Price=250000},
            new Product{Name="Áo bomber",  CategoryId=2, Price=1000000},
            new Product{Name="Quần bò",  CategoryId=3, Price=250000},
            new Product{Name="Quần kaki",  CategoryId=3, Price=300000},
            new Product{Name="Quần jogger",  CategoryId=3, Price=500000},

            };

            products.ForEach(s => context.Product.Add(s));
            context.SaveChanges();
        }
    }
}
