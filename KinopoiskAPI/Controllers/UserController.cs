﻿using KinopoiskAPI.Dto;
using KinopoiskAPI.Services.Interfaces;
using KinopoiskAPI.Utils.Hasher;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KinopoiskAPI.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [Authorize]
        [HttpGet("get-user")]
        public async Task<IActionResult> GetUser()
        {
            var user = await _userService.GetUser(User.Identity?.Name);
            if (user != null)
                return Ok(_userService.GetUserInfo(user));
            return Unauthorized();
        }

        [AllowAnonymous]
        [HttpPost("auth")]
        public async Task<IActionResult> Auth([FromBody] UserLoginDto info)
        {
            var user = await _userService.GetUser(info.Email);

            if (user == null || !Hasher.CheckPassword(info.Password, user.Password, user.Salt))
                return Unauthorized();

            return Ok(_userService.GetToken(user));
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterDto info)
        {
            var user = await _userService.GetUser(info.Email);
            if (user != null)
                return BadRequest();
            if (await _userService.AddUser(info))
                return Ok();
            return BadRequest();
        }
    }
}