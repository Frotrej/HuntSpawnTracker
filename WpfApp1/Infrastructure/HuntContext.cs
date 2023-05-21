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
        public HuntContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Map> Maps { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}
