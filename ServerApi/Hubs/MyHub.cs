using Microsoft.AspNetCore.SignalR;

namespace ServerApi.Hubs
{
    public class MyHub : Hub
    {
        public async Task Changed(string value)
        {
            await Clients.All.SendAsync("ChangeReceived", value);
        }
    }
}
