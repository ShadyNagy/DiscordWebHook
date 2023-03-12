using System.Text.Json.Serialization;

namespace DiscordWebHook.Interfaces;

public interface IEmbedProxyUrl
{
	[JsonPropertyName("proxy_url")]
	string? ProxyUrl { get; set; }
}
