using DiscordWebHook.Interfaces;
using Newtonsoft.Json;

namespace DiscordWebHook.Models
{
	public class EmbedFooter : IEmbedIconUrl, IEmbedIconProxyUrl
	{
		[JsonProperty("text")]
		public string Text { get; set; }
		public string IconUrl { get; set; }
		public string ProxyIconUrl { get; set; }
	}
}