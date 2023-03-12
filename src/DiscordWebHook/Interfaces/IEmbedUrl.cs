using System.Text.Json.Serialization;

namespace DiscordWebHook.Interfaces;

public interface IEmbedUrl
{
	[JsonPropertyName("url")]
	string? Url { get; set; }
}
