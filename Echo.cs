using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

public class Echo
{
    public static void Main()
    {
        new WebHostBuilder()
            .UseKestrel()
            .Configure(app =>
                app.Run(async context =>
                    await context.Request.Body
                        .CopyToAsync(context.Response.Body)
                )
            )
            .Build()
            .Run();
    }
}