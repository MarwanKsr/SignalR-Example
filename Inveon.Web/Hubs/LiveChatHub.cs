using Inveon.Web.Models;
using Microsoft.AspNetCore.SignalR;

namespace Inveon.Web.Hubs
{
    public class LiveChatHub : Hub
    {
        protected IHubContext<LiveChatHub> _context;

        public LiveChatHub(IHubContext<LiveChatHub> context)
        {
            _context = context;
        }

        public async Task SendMessage(string message, string fullName)
        {
            await _context.Clients.All.SendAsync("SendMessage", fullName, message);
        }
    }
}
