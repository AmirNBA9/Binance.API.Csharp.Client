# Binance API Csharp Client!
### C#.NET client for Binance Exchange API.

## Features
- **Very easy** to understand and get started.
- **Complete implementation** of the Binance API and WebSockets.
- Validates transactions using the **[Binance Trading Rules](https://support.binance.com/hc/en-us/articles/115000594711-Trading-Rule)**
- API results **deserialized** to concrete objects for ease of usage.
- Includes a **ready to go** test project with **all possible API calls**, just provide your API Key and Secret.

## Getting Started
In order to use signed methods you need to [create a Binance account](https://www.binance.com/register.html?ref=10200312), if you already have one, go to your account and create a new API private key.

Create an instance of the **APIClient** which receive the following parameters:

* **ApiKey** - *Key used to authenticate within the API.*
* **ApiSecret** - *API secret used for signed API calls.*
* **ApiUrl (Optional)** - *Base URL of the API.*
* **WebSocketEndpoint (Optional)** - *URL of the WebSockets.* 
```c#
    var apiClient = new ApiClient("@Your-API-Key", "@Your-API-Secret");
```

Create an instance of the **BinanceClient** which will receive the previously created APIClient
 
```c#
    var binanceClient = new BinanceClient(apiClient);
```

## Documentation and Examples
- [General Methods](/Documentation/GeneralMethods.md)
- [Market Methods](/Documentation/MarketMethods.md)
- [Account Methods](/Documentation/AccountMethods.md)
- [User Stream Methods](/Documentation/UserStreamMethods.md)
- [WebSocket Methods](/Documentation/WebSocketMethods.md)

## Donations
If you find this tool useful, you can show you support with a kind donation:

** USDT: TEzHBMGGsGnyBimELJPnDppiLviDo2xN7Z
