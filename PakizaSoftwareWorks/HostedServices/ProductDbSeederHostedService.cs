
using PakizaSoftwareWorks.Models;

namespace PakizaSoftwareWorks.HostedServices
{
    public class ProductDbSeederHostedService : IHostedService
    {
        private readonly IServiceProvider serviceProvider;
        public ProductDbSeederHostedService(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;

        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {

            var scope = serviceProvider.CreateScope();
            var seeder = scope.ServiceProvider.GetRequiredService<DbSeeder>();
            await seeder.SeedAsync();
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
        }

    }
}
