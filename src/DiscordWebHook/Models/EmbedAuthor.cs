using DiscordWebHook.Interfaces;
using Newtonsoft.Json;

namespace DiscordWebHook.Models
{
	public class EmbedAuthor : EmbedUrl, IEmbedIconUrl, IEmbedIconProxyUrl
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		public string IconUrl { get; set; }
		public string ProxyIconUrl { get; set; }
	}
}