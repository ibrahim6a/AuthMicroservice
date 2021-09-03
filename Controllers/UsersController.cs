using System;
using Microsoft.AspNetCore.Mvc;
using AuthMicroservice.Models;
using AuthMicroservice.Services;

namespace AuthMicroservice.Controllers {
    
    [ApiController]
    [Route("[controller]")]
    public class UsersController: ControllerBase {

        UserServices _userServices;

        public UsersController(UserServices userServices) {
            _userServices = userServices;
        }

        [HttpPost]
        public IActionResult RegisterUser(UserDto user) {

            bool Something = _userServices.RegisterUser(user);
            return Ok(user);
        }

    }
}
