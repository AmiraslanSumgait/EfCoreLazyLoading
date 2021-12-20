using LazyLoadingActivate.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingActivate.Context
{
    public class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-5EGU4LU;Initial Catalog=LazyLoading;Integrated Security=True;MultipleActiveResultSets=true;").UseLazyLoadingProxies();
        }
        public DbSet<Product>?Books { get; set; }
        public DbSet<Category>?Categories { get; set; }
    }
}
