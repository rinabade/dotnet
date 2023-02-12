using System;
using Microsoft.AspNetCore.Hosting;
using Apexrestaurant.Api;
namespace Apexrestaurant.Api
{
    public class Program
    {
         public static void Main(String[] args)
         {
             var host = new WebHostBuilder()
             .UseKestrel()
             .UseStartup<Startup>()
             .Build();
             host.Run();
         }

    //     public static void Main(string[] args)
    // {
    //     CreateHostBuilder(args).Build().Run();
    // }

    // public static IHostBuilder CreateHostBuilder(string[] args) =>
    //     Host.CreateDefaultBuilder(args)
    //         .ConfigureWebHostDefaults(webBuilder =>
    //         {
    //             webBuilder.UseStartup<Startup>();
    //         });
    }
}