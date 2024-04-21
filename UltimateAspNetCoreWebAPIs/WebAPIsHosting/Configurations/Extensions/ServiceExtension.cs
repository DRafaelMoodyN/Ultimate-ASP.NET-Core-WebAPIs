
namespace WebAPIsHosting.Configurations {

    // Todas las clas de Extension tiene que ser static
    public static class ServiceExtension {

        // Configurar cadena de conexion
        public static void ConfigureSql(this IServiceCollection services, IConfiguration config) {
            services.AddDbContext<AppDbContext>(x => {
                x.UseSqlServer(config.GetConnectionString("AppDbContext"));
            });
        }

        // AddScoped es metodo para registrar servicios en el contenedor de dependencias
        // en el contexto de inyeccion de dependencia, el tiempo de vida de Scoped sig que
        // se crea una ves por cada solicitud Http, esto es util para componentes que deben
        // tener un estado especifico
        public static void ConfigureRepository(this IServiceCollection services) {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }

        // Configurar los cors: El intercambio de recursos de origen cruzado
        public static void ConfigureCors(this IServiceCollection services) {
            services.AddCors(opts => {
                opts.AddPolicy("CorsPolicy", builder =>
                // Permitira cualquier origen
                // Podemos usar WithOrigins("https://example.com")
                    builder.AllowAnyOrigin()
                    // Permite todos verbos http que podemos usar
                    .AllowAnyMethod()
                    // Permite todos los encabezados en las solitudes
                    .AllowAnyHeader()
                );
            });
        }
    }
}
