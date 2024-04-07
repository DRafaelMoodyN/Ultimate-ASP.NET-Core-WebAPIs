﻿namespace WebAPIsHosting.Configurations {

    // Todas las clas de Extension tiene que ser static
    public static class ServiceExtension {

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