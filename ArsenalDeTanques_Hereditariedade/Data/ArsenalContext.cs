using ArsenalDeTanques.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArsenalDeTanques.Data
{
    public class ArsenalContext : DbContext
    {
        public ArsenalContext(DbContextOptions<ArsenalContext> options) : base(options)
        {}

        public DbSet<Tanque> Tanque { get; set; }
    }
}
