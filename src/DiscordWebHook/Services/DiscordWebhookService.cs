using DiscordWebHook.Interfaces;
using DiscordWebHook.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DiscordWebHook.Services;

public class DiscordWebhookService : IDiscordWebhookService
{
	private readonly HttpClient _httpClient = new();
	private readonly IAppLogger<DiscordWebhookService> _logger;

	public DiscordWebhookService(IAppLogger<DiscordWebhookService> logger)
	{
		_logger = logger;
	}

	public Task<bool> SendAsync(ulong id, string token, string contentBody, string? username = null, string? avatarUrl = null, bool isTTS = false, IEnumerable<Embed>? embeds = null)
	{
		var webhookUrl = $"https://discordapp.com/api/webhooks/{id}/{token}";

		return SendAsync(webhookUrl, contentBody, username, avatarUrl, isTTS, embeds);
	}

	public async Task<bool> SendAsync(string webHookUrl, string contentBody, string? username = null, string? avatarUrl = null, bool isTTS = false, IEnumerable<Embed>? embeds = null)
	{
		var request = new WebHookRequest(contentBody, username, avatarUrl, isTTS, embeds);
		var json = JsonSerializer.Serialize(request);

		using var content = new StringContent(json, Encoding.UTF8, "application/json");

		HttpResponseMessage response = await _httpClient.PostAsync(webHookUrl, content);
		response.EnsureSuccessStatusCode();

		return true;
	}
}
