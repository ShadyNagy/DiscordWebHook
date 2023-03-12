using Newtonsoft.Json;

namespace DiscordWebHook.Interfaces
{
	public interface IEmbedIconUrl
	{
		[JsonProperty("icon_url")]
		string IconUrl { get; set; }
	}
}
