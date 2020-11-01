#nullable enable
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Exercise1.Models;
using Hand_In_2.Data;
using Microsoft.AspNetCore.Mvc;

namespace REST_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet]
        public async Task<ActionResult<User>> logIn([FromQuery] string? userName, [FromQuery] string? password)
        {
            try
            {
                User user = await _userService.LogInUser(userName, password);
                return Ok(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ObjectResult> RegisterUser([FromBody] User user)
        {
            try
            {
                await _userService.RegisterUser(user);
                return Ok(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);

            }
                
        }
    }
}