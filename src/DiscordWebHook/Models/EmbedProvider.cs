using Newtonsoft.Json;

namespace DiscordWebHook.Models
{
	public class EmbedProvider : EmbedUrl
	{
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
