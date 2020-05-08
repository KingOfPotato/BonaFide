using Microsoft.AspNetCore.SignalR;
using BonaFide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonaFide.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(Message message) =>
            await Clients.All.SendAsync("receiveMessage", message);
    }
}
