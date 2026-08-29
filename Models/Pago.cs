namespace TiendaOnlineAPI.Models
{
    public class Pago
    {
        public int Id { get; set; } // 👈 Clave primaria

        public int PedidoId { get; set; } // 👈 Relación con Pedido
        public required string Metodo { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }
}

