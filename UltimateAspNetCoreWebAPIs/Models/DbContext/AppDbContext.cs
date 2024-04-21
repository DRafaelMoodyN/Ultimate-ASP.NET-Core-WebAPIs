namespace Models
{
    public class AppDbContext:DbContext
    {
        // DbContextOptions proporciona opciones de configuracion especifica
        // para el contexto de la bd
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }

        public DbSet<Company> Company { get; set; } 
        public DbSet<Employee> Employee { get; set; }

        // Configuracion de la cadena de conexion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

        }
    }
}


// Add-Migration DatabaseCreation

