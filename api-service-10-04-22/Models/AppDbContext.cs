using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_service_10_04_22.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
