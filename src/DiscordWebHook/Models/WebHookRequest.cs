using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordWebHook.Models
{
	internal class WebHookRequest
	{
		[JsonProperty("content")]
		public string Content { get; set; }
		[JsonProperty("username")]
		public string Username { get; set; }
		[JsonProperty("avatar_url")]
		public string AvatarUrl { get; set; }
		// ReSharper disable once InconsistentNaming
		[JsonProperty("tts")]
		public bool IsTTS { get; set; }
		[JsonProperty("embeds")]
		public List<Embed> Embeds { get; set; } = new List<Embed>();

		public WebHookRequest(string content, string username = null, string avatarUrl = null, bool isTTS = false, IEnumerable<Embed> embeds = null)
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
}
