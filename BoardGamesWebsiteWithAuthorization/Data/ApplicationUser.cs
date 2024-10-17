using Microsoft.AspNetCore.Identity;

namespace BoardGamesWebsiteWithAuthorization.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public DateOnly? DateOfBirth { get; set; }
        public string? Adress { get; set; }
        public string? PrefferedLocalization { get; set; }
        public string? UserDescription { get; set; }
    }

}
