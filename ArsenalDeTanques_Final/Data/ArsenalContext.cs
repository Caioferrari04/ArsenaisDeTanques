using ArsenalDeTanques.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArsenalDeTanques.Data
{
    public class ArsenalContext : IdentityDbContext
    {
        public ArsenalContext(DbContextOptions<ArsenalContext> options) : base(options)
        {}

        public DbSet<Tanque> Tanque { get; set; }
        public DbSet<Nacionalidade> Nacionalidade { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<TipoTanque> TipoTanque { get; set; }
    }
}
