using System.Text.Json.Serialization;

namespace DiscordWebHook.Interfaces;

public interface IEmbedDimension
{
	[JsonPropertyName("height")]
	int Height { get; set; }
	[JsonPropertyName("width")]
	int Width { get; set; }
}
