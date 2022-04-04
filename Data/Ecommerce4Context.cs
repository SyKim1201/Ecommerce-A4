using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ecommerce4.Models;

namespace Ecommerce4.Data
{
    public class Ecommerce4Context : DbContext
    {
        public Ecommerce4Context (DbContextOptions<Ecommerce4Context> options)
            : base(options)
        {
        }

        public DbSet<Ecommerce4.Models.Comments> Comments { get; set; }

        public DbSet<Ecommerce4.Models.Products> Products { get; set; }
    }
}
