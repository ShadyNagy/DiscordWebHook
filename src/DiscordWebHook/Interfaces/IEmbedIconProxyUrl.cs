using System.Text.Json.Serialization;

namespace DiscordWebHook.Interfaces;

public interface IEmbedIconProxyUrl
{
	[JsonPropertyName("proxy_icon_url")]
	string? ProxyIconUrl { get; set; }
}
