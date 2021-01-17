using System.Linq;
using BlazorApp3.Server.Data;
using BlazorApp3.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp3.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public UserController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("{username}/validate")]
        public UserValidationResult ValidateUser(string username)
        {
            var user = context.Users.FirstOrDefault(x => x.UserName == username);

            return new UserValidationResult
            {
                Exists = user != null
            };
        }
    }
}
