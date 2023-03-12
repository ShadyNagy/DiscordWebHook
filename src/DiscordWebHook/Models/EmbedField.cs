﻿
using Newtonsoft.Json;

namespace DiscordWebHook.Models
{
	public class EmbedField
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("value")]
		public string Value { get; set; }
		[JsonProperty("inline")]
		public bool Inline { get; set; }
	}
}
