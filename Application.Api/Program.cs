using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Figgle;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Application.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(FiggleFonts.Standard.Render($"Application GraphQL API"));
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Application.Api started. Press Ctrl+C to exit", Console.ForegroundColor);
			CreateHostBuilder(args).Build().RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
