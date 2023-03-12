using DiscordWebHook.Interfaces;

namespace DiscordWebHook.Models
{
	public abstract class EmbedUrl : IEmbedUrl
	{
		public string Url { get; set; }
	}
}
