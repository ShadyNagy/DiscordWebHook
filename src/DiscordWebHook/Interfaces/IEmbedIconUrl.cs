using System.Text.Json.Serialization;

namespace DiscordWebHook.Interfaces;

public interface IEmbedIconUrl
{
	[JsonPropertyName("icon_url")]
	string? IconUrl { get; set; }
}
