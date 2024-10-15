using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BoardGamesWebsiteWithAuthorization.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<BoardGamesWebsiteWithAuthorization.Models.GameModel> Game { get; set; } = default!;
    }
}
