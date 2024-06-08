using Microsoft.AspNetCore.Identity;

namespace StorageSystem.Models
{
    public class ApplicationUser : IdentityUser
    {

        [PersonalData]
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
    }
}
