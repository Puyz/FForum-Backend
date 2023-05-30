using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Abstracts;

namespace FForum.Controllers
{
    [Route("api/messages")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        IMessageService messageService;

        public MessagesController(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        [HttpGet("getbypostid")]
        public IActionResult GetByPostId([FromQuery] int postId) {
            var result = messageService.GetMessagesByPostId(postId);
            return (result.Success) ? Ok(result) : BadRequest();
        }
    }
}
