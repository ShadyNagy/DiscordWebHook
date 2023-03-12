using Newtonsoft.Json;

namespace DiscordWebHook.Interfaces
{
	public interface IEmbedUrl
	{
		[JsonProperty("url")]
		string Url { get; set; }
	}
}
