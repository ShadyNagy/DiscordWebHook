using System.Text.Json.Serialization;

namespace DiscordWebHook.Models;

public class EmbedProvider : EmbedUrl
{
	[JsonPropertyName("name")]
	public string? Name { get; set; }
}
