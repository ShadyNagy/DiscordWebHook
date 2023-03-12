using Newtonsoft.Json;

namespace DiscordWebHook.Interfaces
{
	public interface IEmbedIconProxyUrl
	{
		[JsonProperty("proxy_icon_url")]
		string ProxyIconUrl { get; set; }
	}
}
