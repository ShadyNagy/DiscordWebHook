using DiscordWebHook.Interfaces;
using System.Text.Json.Serialization;

namespace DiscordWebHook.Models;

public class EmbedAuthor : EmbedUrl, IEmbedIconUrl, IEmbedIconProxyUrl
{
	[JsonPropertyName("name")]
	public string? Name { get; set; }
	public string? IconUrl { get; set; }
	public string? ProxyIconUrl { get; set; }
}
