namespace Models
{
    public class AppDbContext:DbContext
    {
        // DbContextOptions proporciona opciones de configuracion especifica
        // para el contexto de la bd
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }

        // Configuracion de la cadena de conexion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer();
        }

    }
}


