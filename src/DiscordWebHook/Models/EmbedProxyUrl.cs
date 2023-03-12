using DiscordWebHook.Interfaces;

namespace DiscordWebHook.Models;

public abstract class EmbedProxyUrl : EmbedUrl, IEmbedProxyUrl
{
	public string? ProxyUrl { get; set; }
}
