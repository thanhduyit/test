using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.EF
{
    public class EShopDbContex : DbContext
    {
        public EShopDbContex(DbContextOptions options) : base(options)
        {
         
        }

        public DbSet<Product> Products { get; set; }
        public DbSet <Caregory> Caregories { get; set; }
    }
}
