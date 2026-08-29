using Microsoft.EntityFrameworkCore;
using TiendaOnlineAPI.Models;

namespace TiendaOnlineAPI.Data {
    public class TiendaContext : DbContext {
        public TiendaContext(DbContextOptions<TiendaContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetallePedidos { get; set; }
        public DbSet<Pago> Pagos { get; set; }
    }
}

