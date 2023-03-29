using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiProducto.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idProducto { get; set; }
        public string Descripcion { get; set; } = null;
        public decimal? Precio { get; set; }
        public int Cantidad { get; set; }
        public bool Garantia { get; set; }
    }
}
