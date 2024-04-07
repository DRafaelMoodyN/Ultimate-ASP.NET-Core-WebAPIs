namespace WebAPIsHosting;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // Servicios
    // Este metodo es llamado en tiempo de ejecucion, se utilisa para agregar servicios al contenedor
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
    }

    // Middleware
    // Este metodo es llamado en tiempo de ejecucion, se utilisa para configurar la canalizacion de 
    // De solicitudes HTTP
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            // Mostrara informacion sobre cualquier expcion no controlada
            app.UseDeveloperExceptionPage();
        }

        // Middleware de canalizacion de solicitud para redirigir automaticamente las solicitudes
        // Http o Https Hypertext Transfer Protocol, esto garantisa que todos los request entrantes
        // se redirigan a traves de una conexio segura
        app.UseHttpsRedirection();

        // Middleware habilita el enrutamiento de las solicitudes HTTP, permite que la aplicacion 
        // mappe las solicitudes entrantes a los controladores y acciones correspondientes
        app.UseRouting();

        // Middleware habilita la autorizacion en la aplicacion, permitiendo que se aplique politicas
        // de autorizacion a las solicitudes entrantes
        app.UseAuthorization();

        // Middleware configura el enrutamiento final para mananejas las solicitudes entrantes
        // define como se responde las solicitudes y aque controlador y acciones se envian
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("Welcome to running ASP.NET Core on AWS Lambda");
            });
        });
    }
}