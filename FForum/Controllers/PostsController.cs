using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Abstracts;

namespace FForum.Controllers
{
    [Route("api/posts")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        IPostService postService;

        public PostsController(IPostService postService)
        {
            this.postService = postService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll() {
            var result = postService.GetAllWithUser();
            return (result.Success) ? Ok(result) : BadRequest();
        }
    }
}
