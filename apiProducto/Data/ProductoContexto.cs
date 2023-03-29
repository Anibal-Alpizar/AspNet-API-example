using apiProducto.Models;
using Microsoft.EntityFrameworkCore;

namespace apiProducto.Data
{
    public class ProductoContexto : DbContext
    {
        public ProductoContexto(
            DbContextOptions<ProductoContexto> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    idProducto = 1,
                    Descripcion = "Arduino",
                    Precio = (decimal)15000.00,
                    Cantidad = 14,
                    Garantia = false
                },
                new Producto
                {
                    idProducto = 2,
                    Descripcion = "Impresora 3D",
                    Precio = (decimal)458999.80,
                    Cantidad = 5,
                    Garantia = true
                }
                );
        }
        public DbSet<Producto> Productos { get; set; }

    }
}
