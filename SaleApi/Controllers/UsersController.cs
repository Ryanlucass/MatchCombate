using Domain.Dtos;
using Domain.Intefaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Data;

namespace MatchCombatApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService) => _userService = userService;

        [HttpPost]
        [SwaggerResponse(201, "user create")]
        [SwaggerResponse(400, "Error to create a user, verify your body request")]
        public UserDto CreateUser([FromBody] UserDto user) => _userService.CreateAsync(user).Result;

        [HttpGet]
        [SwaggerResponse(200, "Sucess")]
        [SwaggerResponse(204, "No content [User]")]
        public List<UserDto> GetUser() => _userService.GetUserAsync().Result;

        [HttpPost("/GetUser")]
        [SwaggerResponse(200, "Sucess")]
        [SwaggerResponse(204, "No content [User]")]
        public UserDto GetUser([FromBody] loginDto user ) => _userService.GetByEmailAsync(user.Email).Result;

        [HttpPatch("{id}")]
        public UserDto PatchUser(Guid id, [FromBody] UserDtoPatch user) => _userService.UpdateAsync(id, user).Result;

        [HttpDelete("{id}")]
        [SwaggerResponse(200, "Sucess")]
        [SwaggerResponse(204, "No content [User]")]
        public bool DeleteUser(Guid id) => _userService.DeleteAsync(id).Result;
    }
}
