using Entities.Concretes;
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
        [HttpGet("get/{postId}")]
        public IActionResult GetAll(int postId)
        {
            var result = postService.GetPost(postId);
            return (result.Success) ? Ok(result) : BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] Post post)
        {
            var result = postService.Add(post);
            return (result.Success) ? Ok(result) : BadRequest();
        }
    }
}
