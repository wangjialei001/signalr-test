using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Chat
{
    public class ChatHub:Hub
    {
        //SendMsg用于前端调用
        public Task SendMsg(ChatMessageInfo info)
        {
            //在客户端实现此处的Show方法
            return Clients.All.SendAsync("Show", info.DeviceID + ":" + info.Message);
        }
    }
}
