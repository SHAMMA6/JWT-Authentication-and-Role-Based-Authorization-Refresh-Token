using JwtAuthAspNet7WebAPI.Core.DbContext;
using JwtAuthAspNet7WebAPI.Core.Dtos;
using JwtAuthAspNet7WebAPI.Core.Entities;
using JwtAuthAspNet7WebAPI.Core.Interfaces;
using JwtAuthAspNet7WebAPI.Core.OtherObjects;
using JwtAuthAspNetWebAPI.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtAuthAspNet7WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    { 
        private readonly IAuthService _authService;
        private readonly ITokenService _tokenService;
        private readonly ApplicationDbContext _context;
        private readonly Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> _userManager;

        public AuthController(IAuthService authService,ITokenService tokenService,ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _authService = authService;
            _tokenService = tokenService;
            _context = context;
            _userManager = userManager;
        }

        // Route For Seeding my roles to DB
        [HttpPost]
        [Route("seed-roles")]
        public async Task<IActionResult> SeedRoles()
        {
             var seerRoles = await _authService.SeedRolesAsync();

            return Ok(seerRoles);
        }


        // Route -> Register
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            var registerResult = await _authService.RegisterAsync(registerDto);

            if (registerResult.IsSucceed)
                return Ok(registerResult);

            return BadRequest(registerResult);
        }


        // Route -> Login            [[USING AuthService & RefreshTokenservice at IMP]]
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            var loginResult = await _authService.LoginAsync(loginDto);

            if (loginResult.IsSucceed)
                return Ok(loginResult);

            return Unauthorized(loginResult);

        }

        // Route -> make user -> admin
        [HttpPost]
        [Route("make-admin")]
        public async Task<IActionResult> MakeAdmin([FromBody] UpdatePermissionDto updatePermissionDto)
        {
             var operationResult = await _authService.MakeAdminAsync(updatePermissionDto);

            if(operationResult.IsSucceed)
                return Ok(operationResult);

            return BadRequest(operationResult);
        }


        // Route -> make admin -> user
        [HttpPost]
        [Route("Delet-admin")]
        public async Task<IActionResult> DeletAdmin([FromBody] UpdatePermissionDto updatePermissionDto)
        {
            var operationResult = await _authService.DeletAdminAsync(updatePermissionDto);

            if (operationResult.IsSucceed)
                return Ok(operationResult);

            return BadRequest(operationResult);
        }




        // Route -> make user -> owner
        [HttpPost]
        [Route("make-owner")]
        public async Task<IActionResult> MakeOwner([FromBody] UpdatePermissionDto updatePermissionDto)
        {
            var operationResult = await _authService.MakeOwnerAsync(updatePermissionDto);

            if (operationResult.IsSucceed)
                return Ok(operationResult);

            return BadRequest(operationResult);
        }


    
    }
}

