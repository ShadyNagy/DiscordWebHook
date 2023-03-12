using DiscordWebHook.Interfaces;
using DiscordWebHook.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DiscordWebHook.Extensions
{
	public static class ConfigureServicesExtensions
	{
		public static IServiceCollection AddDiscordServices(this IServiceCollection services)
		{
			services
				.AddScoped<IDiscordWebhookService, DiscordWebhookService>();				

			return services;
		}
	}
}
