using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CommonLibrary.RabbitMQ
{
    public static class StartupExtension
    {
        public static void AddCommonService(this IServiceCollection services, IConfiguration configuration )
        {
            services.Configure<RabbitMqConfiguration>(a => configuration.GetSection(nameof(RabbitMqConfiguration)).Bind(a));
           //services.Configure<RabbitMqConfiguration>(Configuration.GetSection("RabbitMqConfiguration"));
            services.AddSingleton<IRabbitMQService, RabbitMQService>();
        }
    }
}
