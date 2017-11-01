using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

public class Echo
{
    public static void Main()
    {
        new WebHostBuilder()
            .UseKestrel(options => {
                options.Limits.MaxConcurrentConnections = 1000;
            })
            .Configure(app =>
                app.Run(async context => {
                    var req = context.Request;
                    var res = context.Response;
                    // echo headers
                    foreach (var header in req.Headers)
                    {
                        res.Headers.Add(header);
                    }
                    // echo body
                    await req.Body.CopyToAsync(res.Body);
                })
            )
            .Build()
            .Run();
    }
}