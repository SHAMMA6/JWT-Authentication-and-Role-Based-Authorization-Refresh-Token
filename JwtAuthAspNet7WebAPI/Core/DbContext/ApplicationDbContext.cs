using JwtAuthAspNet7WebAPI.Core.Entities;
using JwtAuthAspNetWebAPI.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthAspNet7WebAPI.Core.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<TokenApiModel> tokenApiModel { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TokenApiModel>(c => c.HasNoKey());
            base.OnModelCreating(builder);
        }

    }
}
