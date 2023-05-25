using Microsoft.AspNetCore.Mvc;
using Services.Abstracts;

namespace FForum.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = userService.GetAllWithRank();
            return (result.Success) ? Ok(result) : BadRequest();
        }
    }
}
