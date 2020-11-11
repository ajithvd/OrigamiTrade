using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OrigamiTrade.Models
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        // public DbSet<RefreshToken> RefreshTokens { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
          //  base.OnModelCreating(builder);
           // builder.Entity<PostTag>().Ignore(xx => xx.Post).HasKey(x => new { x.PostId, x.TagName });
        //}
    }
}
