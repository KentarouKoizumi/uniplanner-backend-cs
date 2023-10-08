using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Api;

public class Program
{
    public static void Main(string[] args)
    {
        CreateWebhostBuilder(args).Build().Run();
    }
    public static IHostBuilder CreateWebhostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
                webBuilder.UseUrls("http://*:80");
            });

}