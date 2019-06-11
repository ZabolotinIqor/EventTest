using Event.DTOs;
using Event.Models;
using Event.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("GetAllUsers")]
        public async Task<ActionResult> GetAllUsers()
        {
            var result = await userService.GetAllUsers();
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("GetUserById")]
        public async Task<ActionResult> GetUserById(int id)
        {
            var result = await userService.GetUserById(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpDelete("DeleteUserById")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            var result = userService.DeleteUser(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost("RegisterUser")]
        public async Task<ActionResult> RegisterUser([FromBody] ReqisterDTO user)
        {
            if (ModelState.IsValid)
            {
                var result = await userService.Reqister(user);
                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }

            return BadRequest("Not correct query");
        }

        [HttpPut("EditUser")]
        public async Task<ActionResult> EditUser([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                var result = await userService.UpdateUser(user);
                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }

            return BadRequest("Not correct query");
        }
        [HttpPost("Login")]
        public async Task<ActionResult> Login([FromBody]LoginDTO loginDto)
        {
            if (ModelState.IsValid)
            {
                var result = await userService.Login(loginDto);
                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }

            return BadRequest("Not correct query");

        }
    }
}
