using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace WebChatSample.Hubs
{
    [HubName("Echo")]
    public class EchoHub : Hub
    {
        public void Send(String text)
        {
            Clients.All.Receive(text);

        }
    }
}