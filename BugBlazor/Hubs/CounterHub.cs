using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugBlazor.Hubs
{
    public class CounterHub:Hub
    {
        public void SendNumber(int number)
        {
            Clients.Others.SendAsync("UpdateNumber", number);
        }
    }
}
