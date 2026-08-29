namespace TiendaOnlineAPI.Models
{
    public class Pedido
    {
        public int Id { get; set; } // 👈 Clave primaria

        public DateTime Fecha { get; set; }
        public int UsuarioId { get; set; } // 👈 Relación con Usuario
    }
}



