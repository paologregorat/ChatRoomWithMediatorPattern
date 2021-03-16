using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatRoomWithMediatorPattern.Abstract;
using ChatRoomWithMediatorPattern.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ChatRoomWithMediatorPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void Get()
        {
            ChatRoom chat = new ChatRoom();
            User user1 = new ChatUser("Gianni");
            User user2 = new ChatUser("Luca");

            chat.Register(user1);
            chat.Register(user2);

            user1.Send("Ciao a tutti", null);
            user1.Send("Ciao Luca, sono Gianni", user2.NickName);
            user2.Send("Ciao Gianni", "Gianni");
        }
    }
}
