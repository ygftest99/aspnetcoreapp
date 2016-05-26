using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace aspnetcoreapp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(context =>
            {
<<<<<<< Updated upstream
                return context.Response.WriteAsync("GIt test Hello from ASP.NET Core!  w22 Guofa yang");
=======
                return context.Response.WriteAsync("GIt 222   test Hello from ASP.NET Core!  w22 Guofa yang");
>>>>>>> Stashed changes
                
            });
        }
    }
}
