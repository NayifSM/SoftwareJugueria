using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shop.Web.Data.Entities;
using System.Linq;
using Ventas.Web.Data.Entities;

namespace Shop.Web.Data
{
    public class DataContext : IdentityDbContext<Usuarios>
    {
        public  DbSet <Product> Products { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<DetallesPedido> DetallesOrden { get; set; }
        public DbSet<DetallesPedidoTemporal> DetallesPedidoTemporal { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Precio)
                .HasColumnType("decimal(18,2)");
            // desabiltar el borrado en cascada de la base de datos

            var cascadeFKs = modelBuilder.Model
                .G­etEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Casca­de);
            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restr­ict;
            }

            base.OnModelCreating(modelBuilder);
        }

    }
}
 