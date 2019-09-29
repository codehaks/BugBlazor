using BugBlazor.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugBlazor.Hubs
{
    public class BugHub:Hub
    {
        public void NotifyEdited(Bug bug)
        {
            Clients.Others.SendAsync("UpdateBug", bug);
        }
    }
}
