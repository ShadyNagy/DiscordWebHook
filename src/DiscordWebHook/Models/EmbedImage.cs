using DiscordWebHook.Interfaces;

namespace DiscordWebHook.Models;

public class EmbedImage : EmbedProxyUrl, IEmbedDimension
{
	public int Height { get; set; }
	public int Width { get; set; }
}
