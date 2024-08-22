using HelloEmpty.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloEmpty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public List<HelloMessage> Get()
        {
            List<HelloMessage> messages = new List<HelloMessage>();
            messages.Add(new HelloMessage() { Message = "Hello WebAPI 1 !" });
            messages.Add(new HelloMessage() { Message = "Hello WebAPI 2 !" });
            messages.Add(new HelloMessage() { Message = "Hello WebAPI 3 !" });

            return messages;
        }

    }
}
