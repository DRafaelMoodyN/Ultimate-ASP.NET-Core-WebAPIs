namespace WebAPIsHosting;

public class Startup {
    public Startup(IConfiguration configuration) {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // Servicios
    // Este metodo es llamado en tiempo de ejecucion, se utilisa para agregar servicios al contenedor
    public void ConfigureServices(IServiceCollection services) {
        services.ConfigureCors();
        services.AddControllers();
    }

    // Middleware
    // Este metodo es llamado en tiempo de ejecucion, se utilisa para configurar la canalizacion de 
    // De solicitudes HTTP
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
        if (env.IsDevelopment()) {
            // Mostrara informacion sobre cualquier expcion no controlada
            app.UseDeveloperExceptionPage();
        } else {
            // Strict-Transport-Security: Politicas de trasnporte de seguridad
            // Cuando se usa se agregar un en cabdesado STS alas repuestas, esto indica que el sitio
            // solo debe acceder a traves de conxiones https, esto protege a los usuarios contra
            // ataques man-in-the-middle y evita ataques SSL stripping
            app.UseHsts();
        }

        // Middleware de canalizacion de solicitud para redirigir automaticamente las solicitudes
        // Http o Https Hypertext Transfer Protocol, esto garantisa que todos los request entrantes
        // se redirigan a traves de una conexio segura
        app.UseHttpsRedirection();
        app.UseStaticFiles();

        // Es importante configurar este middleware correctamente, especialmente en entornos donde se
        // utilizan proxies o balanceadores de carga, para garantizar que la aplicación reciba información
        // precisa sobre la solicitud HTTP, como las direcciones IP del cliente y el protocolo utilizado,
        // especialmente cuando se usa HTTPS detrás de un proxy. Esto ayuda a que la aplicación funcione
        // correctamente en entornos de producción complejos y asegura que se mantenga la seguridad y la
        // integridad de la solicitud HTTP.

        app.UseForwardedHeaders(new ForwardedHeadersOptions {
            ForwardedHeaders = ForwardedHeaders.All
        });

        app.UseCors("CorsPolicy");

        // Middleware habilita el enrutamiento de las solicitudes HTTP, permite que la aplicacion 
        // mappe las solicitudes entrantes a los controladores y acciones correspondientes
        app.UseRouting();

        // Middleware habilita la autorizacion en la aplicacion, permitiendo que se aplique politicas
        // de autorizacion a las solicitudes entrantes
        app.UseAuthorization();

        // Middleware configura el enrutamiento final para mananejas las solicitudes entrantes
        // define como se responde las solicitudes y aque controlador y acciones se envian
        app.UseEndpoints(endpoints => {
            endpoints.MapControllers();
            endpoints.MapGet("/", async context => {
                await context.Response.WriteAsync("Welcome to running ASP.NET Core on AWS Lambda");
            });
        });
    }
}