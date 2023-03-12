using DiscordWebHook.Interfaces;
using System.Text.Json.Serialization;

namespace DiscordWebHook.Models;

public class EmbedFooter : IEmbedIconUrl, IEmbedIconProxyUrl
{
	[JsonPropertyName("text")]
	public string? Text { get; set; }
	public string? IconUrl { get; set; }
	public string? ProxyIconUrl { get; set; }
}
