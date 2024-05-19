using JwtAuthAspNet7WebAPI.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JwtAuthAspNetWebAPI.Core.Entities
{
    
   
    public class TokenApiModel
    {
       
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }


    }
}
