using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace dotnet_web_example
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) { }

        public void Configure(IApplicationBuilder app)
        {
            // echo body
            app.Run(async context => {
                await context.Request.Body
                    .CopyToAsync(context.Response.Body);
            });
        }
    }
}
