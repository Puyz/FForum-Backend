using Microsoft.AspNetCore.Mvc;
using Services.Abstracts;

namespace FForum.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAllWithRank();
            return (result.Success) ? Ok(result) : BadRequest();
        }
    }
}
