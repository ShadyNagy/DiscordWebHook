using Newtonsoft.Json;

namespace DiscordWebHook.Interfaces
{
	public interface IEmbedDimension
	{
		[JsonProperty("height")]
		int Height { get; set; }
		[JsonProperty("width")]
		int Width { get; set; }
	}
}
