using Microsoft.AspNetCore.SignalR;

namespace ServerApi.Hubs
{
    public class MyHub : Hub
    {
        public async Task Changed(string usersent, string sender)
        {
            await Clients.All.SendAsync("ChangeReceived", usersent, sender);
        }
    }
}
