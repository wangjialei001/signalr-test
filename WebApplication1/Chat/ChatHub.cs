using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Chat
{
    public class ChatHub:Hub
    {
        //SendMsg用于前端调用
        public Task SendAllMsg(ChatMessageInfo info)
        {
            //在客户端实现此处的Show方法
            return Clients.All.SendAsync("Show", info.DeviceID + ":" + info.Message);
        }

        public Task SendMsg(ChatMessageInfo info)
        {
            for(int i = 0; i < 10; i++)
            {
                Clients.Client(Context.ConnectionId).SendAsync("Show", info.DeviceID + ":" + info.Message);
            }
            return Clients.Client(Context.ConnectionId).SendAsync("Show", info.DeviceID + ":" + info.Message);
        }
    }
}
