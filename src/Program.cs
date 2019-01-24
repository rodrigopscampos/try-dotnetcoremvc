using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace aspnetcoremvc
{
    public class Program
    {
        public static readonly Dictionary<string, string> _argsMap = 
        new Dictionary<string, string>
        {
            { "-h", "Host" },
            { "-p", "Port" }
        };

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) => {
                    config.AddCommandLine(args, _argsMap);
                })
                .UseStartup<Startup>();
    }
}
