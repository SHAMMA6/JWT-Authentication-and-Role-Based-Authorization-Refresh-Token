using JwtAuthAspNetWebAPI.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;

namespace JwtAuthAspNet7WebAPI.Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }

      
    }
}
