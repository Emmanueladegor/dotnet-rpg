using System;
using System.Threading.Tasks;
using Dotnet_rpg.Data;
using Dotnet_rpg.Dtos.User;
using Dotnet_rpg.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_rpg.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegisterDto request)
        {
            ServiceResponse<int> response = await _authRepo.Register(
                new User { Username = request.Username }, request.Password
                );
            if(!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }



        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserRegisterDto request)
        {
            ServiceResponse<string> response = await _authRepo.Login(request.Username, request.Password); 
               
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
