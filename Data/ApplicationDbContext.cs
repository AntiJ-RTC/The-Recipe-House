using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using The_Recipe_House.Models;

namespace The_Recipe_House.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Profile> Profiles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Recipe>()
                .HasMany(e => e.Comments)
                .WithOne(e => e.Recipe)
                .HasForeignKey(e => e.RecipeId)
                .HasPrincipalKey(e => e.Id);
            builder.Entity<Recipe>().HasData(
                new Recipe { Id = 1, ImageURL = "https://www.allrecipes.com/thmb/IGrCIXMupDR37mMPpZ4DWfBgWM4=/750x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/3661599-how-to-make-perfect-hard-boiled-eggs-Chef-John-1x1-1-bcdf26c1d40645e996e26ae1eedd8d14.jpg", Title = "Hard boiled Eggs", Description = "An easy breakfast item that is rich in protein, but low on calories!", Ingredients = "6 eggs", Instructions = "1. Place eggs in a saucepan and pour in cold water to cover; place over high heat. When water starts to simmer and eggs start to dance around a little, turn off heat, cover the pan quickly with a lid, and let stand for 17 minutes. Don't peek.\r\n\r\n2. Pour out hot water and pour cold water over eggs. Drain and refill with cold water; let stand until eggs are cool, about 20 minutes.\r\n\r\n3. Peel eggs under running water.", PrepTime = 5, CookTime = 5 }
                );
        }
    }
}
