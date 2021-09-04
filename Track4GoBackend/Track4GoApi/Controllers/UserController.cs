using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Track4GoApplication.Interface;
using Track4GoApplication.ViewModels;

namespace Track4GoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController( IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userService.GetUser());
        }
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserViewModel userViewModel)
        {
            if (userViewModel == null)
            {
                return BadRequest();
            }

            if(userViewModel.Id_User == Guid.Empty)
            {
                ModelState.AddModelError("Id", "ID_user can't be empty");
            }
            _userService.Create(userViewModel);
            return Created("Created a new user", true);
        }
    }
}
