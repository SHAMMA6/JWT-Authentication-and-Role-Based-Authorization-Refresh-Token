
namespace JwtAuthAspNet7WebAPI.Core.Dtos
{
    public class AuthServiceResponseDto
    {


        internal DateTime RefreshTokenExpiryTime;
        internal DateTime Expiration;

        public bool IsSucceed { get; set; }
        public string Message { get; set; }
       
            public string? Token { get; set; }
            public string? RefreshToken { get; set; }
        
    }
}
