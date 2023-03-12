using DiscordWebHook.Interfaces;

namespace DiscordWebHook.Models
{
	public class EmbedThumbnail : EmbedProxyUrl, IEmbedDimension
	{
		public int Height { get; set; }
		public int Width { get; set; }
	}
}
