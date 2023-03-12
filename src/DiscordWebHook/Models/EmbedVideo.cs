using DiscordWebHook.Interfaces;

namespace DiscordWebHook.Models
{
	public class EmbedVideo : EmbedUrl, IEmbedDimension
	{
		public int Height { get; set; }
		public int Width { get; set; }
	}
}
