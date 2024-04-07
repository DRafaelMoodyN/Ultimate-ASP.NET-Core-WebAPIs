# Ultimate-ASP.NET-Core-WebAPIs

# Archivo .vs
Contiene informacion relacionada con la configuracion de la solucion y  de con Visual Studio

# Archivo bin
Contiene archivos binarios generados durante la compilacion del proyecto incluye archivos de 
emsamblado .dll

# Archivo obj
Contiene archivos binarios generados durante la compilacion del proyecto incluy archivo 
temporales

#  LaunchSettings.json 

Archivo de configuración: define como se debe iniciar la aplicación durante el desarrollo, 
proporciona configuraciones para diferentes perfiles de lanzamiento como Development, 
Production y cualquier otro entorno que necesites, puede incluir información de depuración

Profile (Perfil): Define diferentes perfiles de lanzamiento el por defecto de Visual Studio 
IIS o cualquier otro definido por el usuario.

Application URL (URL de la aplicación): Especifica la URL base en la que se ejecutara la 
aplicación localmente durante el desarrollo.

Enviroment variables (Variables de entorno): Permite definir variables de entorno especificas 
para cada perfil de lanzamiento.

LaunchUrl: esta propiedad determina que Visual Studio abra el navegador con nuestra URL definida
Recomendación por razones de seguridad el archivo LaunchSettings.json no se debe incluir en el 
entorno de producción por que puede exponer información sensible que podría comprometer datos 
críticos, en su lugar se usan servicios de administración como AWS Secret Manager

# Extension Methods

Un método de extensión es inherentemente un método estático es una técnica que permite agregar funcionalidades adicionales a tipos existentes sin modificar directamente el código fuente de 
esos tipos.

En el contexto de las Web APIs en .NET Core, los métodos de extensión pueden ser utilizados 
para agregar funcionalidades comunes a los controladores, servicios, middleware y otros 
componentes de la aplicación. Esto ayuda a mantener un código limpio y modular, ya que permite 
encapsular lógica adicional en métodos que pueden ser llamados como si fueran parte del propio 
tipo al que se extiende.
