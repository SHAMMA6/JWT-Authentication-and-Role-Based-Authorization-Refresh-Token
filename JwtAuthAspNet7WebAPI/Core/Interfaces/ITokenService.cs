using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using JwtAuthAspNet7WebAPI.Core.Dtos;

namespace JwtAuthAspNet7WebAPI.Core.Interfaces
{
    public interface ITokenService
    {
        public JwtSecurityToken CreateToken(List<Claim> authClaims);
        public string GenerateRefreshToken();
        public ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token);

    }
}
