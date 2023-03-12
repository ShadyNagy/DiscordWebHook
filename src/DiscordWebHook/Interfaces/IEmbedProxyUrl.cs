using Newtonsoft.Json;

namespace DiscordWebHook.Interfaces
{
	public interface IEmbedProxyUrl
	{
		[JsonProperty("proxy_url")]
		string ProxyUrl { get; set; }
	}
}
