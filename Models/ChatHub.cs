﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
namespace WebApplication2.Models
{
    public class ChatHub:Hub
    {

        public async Task SendMessage(string userName,string message) {

             await Clients.All.SendAsync("ReceiveMessage",userName,message);
        }
    }
}
