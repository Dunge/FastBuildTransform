using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ClassLibrary
{
    public class Worker : BackgroundService
    {
        public Worker(ILogger<Worker> logger)
        {
            logger.LogInformation("Worker console logging - change me");
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            return Task.CompletedTask;
        }
    }
}
