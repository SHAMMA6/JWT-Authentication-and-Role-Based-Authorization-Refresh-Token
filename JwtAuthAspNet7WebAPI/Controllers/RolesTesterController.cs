using JwtAuthAspNet7WebAPI.Core.Dtos;
using JwtAuthAspNet7WebAPI.Core.Entities;
using JwtAuthAspNet7WebAPI.Core.OtherObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace JwtAuthAspNet7WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RolesTesterController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            return Ok(Summaries);
        }

        [HttpGet]
        [Route("GetUserRole")]
        [Authorize(Roles = StaticUserRoles.USER)]
        public IActionResult GetUserRole()
        {
            return Ok(Summaries);
        }

        [HttpGet]
        [Route("GetAdminRole")]
        [Authorize(Roles = StaticUserRoles.ADMIN)]
        public IActionResult GetAdminRole()
        {
            return Ok(Summaries);
        }

        [HttpGet]
        [Route("GetOwnerRole")]
        [Authorize(Roles = StaticUserRoles.OWNER)]
        public IActionResult GetOwnerRole()
        {
            return Ok(Summaries);
        }

        //[HttpPost]
        //[Route("register")]
        //public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        //{
        //    var userExists = await _userManager.FindByNameAsync(registerDto.UserName);
        //    if (userExists != null)
        //        return StatusCode(StatusCodes.Status500InternalServerError, new AuthServiceResponseDto { IsSucceed = false, Message = "User already exists!" });

        //    ApplicationUser user = new()
        //    {
        //        Email = registerDto.Email,
        //        SecurityStamp = Guid.NewGuid().ToString(),
        //        UserName = registerDto.UserName
        //    };
        //    var result = await _userManager.CreateAsync(user, registerDto.Password);
        //    if (!result.Succeeded)
        //        return StatusCode(StatusCodes.Status500InternalServerError, new AuthServiceResponseDto { IsSucceed = false, Message = "User creation failed! Please check user details and try again." });

        //    return Ok(new AuthServiceResponseDto { IsSucceed = true, Message = "User created successfully!" });
        //}

        //[HttpPost]
        //[Route("register-admin")]
        //public async Task<IActionResult> RegisterAdmin([FromBody] RegisterDto registerDto)
        //{
        //    var userExists = await _userManager.FindByNameAsync(registerDto.UserName);
        //    if (userExists != null)
        //        return StatusCode(StatusCodes.Status500InternalServerError, new AuthServiceResponseDto { IsSucceed = false, Message = "User already exists!" });

        //    ApplicationUser user = new()
        //    {
        //        Email = registerDto.Email,
        //        SecurityStamp = Guid.NewGuid().ToString(),
        //        UserName = registerDto.UserName
        //    };
        //    var result = await _userManager.CreateAsync(user, registerDto.Password);
        //    if (!result.Succeeded)
        //        return StatusCode(StatusCodes.Status500InternalServerError, new AuthServiceResponseDto { IsSucceed = false, Message = "User creation failed! Please check user details and try again." });

        //    if (!await _roleManager.RoleExistsAsync(StaticUserRoles.ADMIN))
        //        await _roleManager.CreateAsync(new IdentityRole(StaticUserRoles.ADMIN));
        //    if (!await _roleManager.RoleExistsAsync(StaticUserRoles.USER))
        //        await _roleManager.CreateAsync(new IdentityRole(StaticUserRoles.USER));

        //    if (await _roleManager.RoleExistsAsync(StaticUserRoles.ADMIN))
        //    {
        //        await _userManager.AddToRoleAsync(user, StaticUserRoles.ADMIN);
        //    }
        //    if (await _roleManager.RoleExistsAsync(StaticUserRoles.ADMIN))
        //    {
        //        await _userManager.AddToRoleAsync(user, StaticUserRoles.USER);
        //    }
        //    return Ok(new AuthServiceResponseDto { IsSucceed = true, Message = "User created successfully!" });
        //}




        //[HttpPost]
        //[Route("login")]
        //public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        //{
        //    var user = await _userManager.FindByNameAsync(loginDto.UserName);
        //    if (user != null && await _userManager.CheckPasswordAsync(user, loginDto.Password))
        //    {
        //        var userRoles = await _userManager.GetRolesAsync(user);

        //        var authClaims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name, user.UserName),
        //            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        //        };

        //        foreach (var userRole in userRoles)
        //        {
        //            authClaims.Add(new Claim(ClaimTypes.Role, userRole));
        //        }

        //        var token = _tokenService.CreateToken(authClaims);
        //        var refreshToken = _tokenService.GenerateRefreshToken();

        //        _ = int.TryParse(_configuration["JWT:RefreshTokenValidityInDays"], out int refreshTokenValidityInDays);

        //        user.RefreshToken = refreshToken;
        //        user.RefreshTokenExpiryTime = DateTime.Now.AddDays(refreshTokenValidityInDays);

        //        await _userManager.UpdateAsync(user);

        //        return Ok(new
        //        {
        //            Token = new JwtSecurityTokenHandler().WriteToken(token),
        //            RefreshToken = refreshToken,
        //            Expiration = token.ValidTo
        //        });
        //    }
        //    return Unauthorized();
        }



    }

