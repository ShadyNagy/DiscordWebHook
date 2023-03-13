[![publish to nuget](https://github.com/ShadyNagy/DiscordWebHook/actions/workflows/nugt-publish.yml/badge.svg)](https://github.com/ShadyNagy/DiscordWebHook/actions/workflows/nugt-publish.yml)
[![DiscordWebHookMessage on NuGet](https://img.shields.io/nuget/v/DiscordWebHookMessage?label=DiscordWebHookMessage)](https://www.nuget.org/packages/DiscordWebHookMessage/)
[![NuGet](https://img.shields.io/nuget/dt/DiscordWebHookMessage)](https://www.nuget.org/packages/DiscordWebHookMessage)
[![License](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/ShadyNagy/DiscordWebHook/blob/main/LICENSE)
    <a href="https://www.paypal.me/shadynagy" alt="paypal">
        <img src="https://img.shields.io/badge/PayPal-tip%20me-green.svg?logo=paypal" />
    </a>

# Discord WebHook

## Get Packages
You can get Autofac by grabbing [the latest NuGet package](https://www.nuget.org/packages/DiscordWebHookMessage). 

## Get Started
Load the DI in Program.cs or Startup.cs
```csharp
services.AddDiscordServices();
```

Use the Discord WebHook Service
```csharp
private readonly IDiscordWebhookService _discordWebhookService;		

public SomeService(IDiscordWebhookService discordWebhookService)
{
  _discordWebhookService = discordWebhookService;
}

public void SendDiscordWebHook() 
{
  _ = await _discordWebhookService.SendAsync(DISCORD_WEBHOOK_LINK, "Message");
}
```
