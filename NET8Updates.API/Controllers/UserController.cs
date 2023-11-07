using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NET8Updates.API.Services;

namespace NET8Updates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers([FromKeyedServices("user")] IUserService userService)
        {
            return Ok(userService.GetUsers());
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById([FromKeyedServices("user")] IUserService userService,int id)
        {
            return Ok(userService.GetUserById(id));
        }
    }
}
