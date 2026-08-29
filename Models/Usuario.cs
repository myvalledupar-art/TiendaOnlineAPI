namespace TiendaOnlineAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; } // 👈 Clave primaria

        public required string Nombre { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
    }
}

