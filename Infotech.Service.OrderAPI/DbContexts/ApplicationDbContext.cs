using Infotech.Service.OrderAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Infotech.Service.OrderAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

    }
}
