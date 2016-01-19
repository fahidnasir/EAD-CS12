using System;
using System.Collections.Generic;
using System.Web;
using Microsoft.AspNet.SignalR;
namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public List<string> ClientsNames { get; set; }
        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);
        }
        public void SendToClient(string name, string message,string clientName)
        {
            Clients.Others.addNewMessageToPage(name, message);
        }
    }
}