using DiscordWebHook.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiscordWebHook.Interfaces
{
  public interface IDiscordWebhookService
  {
    Task<bool> SendAsync(ulong id, string token, string contentBody, string username = null, string avatarUrl = null, bool isTTS = false, IEnumerable<Embed> embeds = null);
    Task<bool> SendAsync(string webhookUrl, string contentBody, string username = null, string avatarUrl = null, bool isTTS = false, IEnumerable<Embed> embeds = null);
  }
}
