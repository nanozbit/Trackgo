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
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userService.GetUser());
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserViewModel request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            if (request.Id_User == Guid.Empty)
            {
                ModelState.AddModelError("Id", "ID_user can't be empty");
            }
            _userService.Create(request);
            return Created("Created a new user", true);
        }

        [HttpPut]
        public IActionResult Put([FromBody] UserViewModel request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            if (request.Id_User == Guid.Empty)
            {
                ModelState.AddModelError("Id", "ID_user can't be empty");
            }
            _userService.Update(request);
            return Created("Update a user", true);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return BadRequest();
            }
			if (id == Guid.Empty)
            {
                ModelState.AddModelError("Id", "ID_user can't be empty");
            }
            _userService.Delete(id);
            return Created("Delete a user", true);
        }

    }
}
