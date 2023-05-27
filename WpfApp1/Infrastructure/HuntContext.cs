using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Infrastructure.Models;

namespace WpfApp1.Infrastructure
{
    public class HuntContext:DbContext
    {
        public HuntContext(DbContextOptions<HuntContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Map> Maps { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Map>().HasData(ProduceInitialData());
            base.OnModelCreating(modelBuilder);
        }

        private List<Map> ProduceInitialData()
        {
            return new List<Map>
            {
                new Map { Id = 1, Name = "Mapa1", MapOccurrences = 1 }
            };
        }
    }
}
