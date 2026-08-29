namespace TiendaOnlineAPI.Models
{
    public class Producto
    {
        public int Id { get; set; } // 👈 Clave primaria

        public required string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}

