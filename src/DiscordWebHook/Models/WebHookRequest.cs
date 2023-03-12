using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscordWebHook.Models;

internal class WebHookRequest
{
	[JsonPropertyName("content")]
	public string Content { get; set; }
	[JsonPropertyName("username")]
	public string? Username { get; set; }
	[JsonPropertyName("avatar_url")]
	public string? AvatarUrl { get; set; }
	// ReSharper disable once InconsistentNaming
	[JsonPropertyName("tts")]
	public bool IsTTS { get; set; }
	[JsonPropertyName("embeds")]
	public List<Embed>? Embeds { get; set; } = new List<Embed>();

	public WebHookRequest(string content, string? username = null, string? avatarUrl = null, bool isTTS = false, IEnumerable<Embed>? embeds = null)
	{
		Content = content;
		Username = username;
		AvatarUrl = avatarUrl;
		IsTTS = isTTS;
		Embeds.Clear();
		if (embeds != null)
		{
			Embeds.AddRange(embeds);
		}
	}
}
