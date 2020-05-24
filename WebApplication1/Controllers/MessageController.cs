using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Chat;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("SignalRCors")]
    public class MessageController : Controller
    {
        private ChatHub hub;
        private MessageController(ChatHub _hub)
        {
            hub = _hub;
        }
        [HttpGet]
        public Task Get([FromQuery]ChatMessageInfo info)
        {
            return hub.SendMsg(info);
        }
       
    }
}
