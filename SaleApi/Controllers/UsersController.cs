using Domain.Dtos.UsersDtos;
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
        public UserDtoGet CreateUser([FromBody] UserDto user) => _userService.CreateAsync(user).Result;

        [HttpGet]
        [SwaggerResponse(200, "Sucess")]
        [SwaggerResponse(204, "No content [User]")]
        public List<UserDtoGet> GetUser() => _userService.GetUseraAsync().Result;
        [HttpGet("{id}")]
        [SwaggerResponse(200, "Sucess")]
        [SwaggerResponse(204, "No content [User]")]
        public UserDtoGet GetUser(Guid id) => _userService.GetByIdAsync(id).Result;

        [HttpPatch("{id}")]
        public UserDtoGet PatchUser(Guid id, [FromBody] UserDtoPatch user) => _userService.UpdateAsync(id, user).Result;

        [HttpDelete("{id}")]
        [SwaggerResponse(200, "Sucess")]
        [SwaggerResponse(204, "No content [User]")]
        public bool DeleteUser(Guid id) => _userService.DeleteAsync(id).Result;
    }
}
