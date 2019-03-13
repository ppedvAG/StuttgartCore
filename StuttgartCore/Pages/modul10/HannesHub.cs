using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StuttgartCore.Pages.modul10
{
    public class HannesHub:Hub
    {
        public void Send(string message)
        {
            Clients.All.SendAsync("ClientRec", message);
        }
    }
}
