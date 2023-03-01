using ClassLibrary;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace FastBuildTransform {
    internal class Program {
        static async Task Main(string[] args) {
            var builder = Host.CreateDefaultBuilder(args);
            builder.UseConsoleLifetime();

            builder.ConfigureLogging((ctx, logging) => {
                logging.ClearProviders();
                logging.AddNLog("NLog.config");
            });
            builder.ConfigureServices((ctx, services) => {
                services.AddHostedService<Worker>();
            });

#pragma warning disable CS0219 // Variable is assigned but its value is never used
            var test = "Main program - change me";
#pragma warning restore CS0219 // Variable is assigned but its value is never used

            var host = builder.Build();
            await host.RunAsync();
        }
    }
}
