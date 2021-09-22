using Imovel.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel.Data.Context
{
    public class ImmobileDbContext : DbContext
    {
        public ImmobileDbContext(DbContextOptions<ImmobileDbContext> options) : base(options) { }

        public DbSet<Immobile> Immobiles { get; set; }
        public DbSet<Address> Address { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ImmobileDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
