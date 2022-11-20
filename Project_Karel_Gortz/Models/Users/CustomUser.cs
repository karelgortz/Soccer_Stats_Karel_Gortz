using Microsoft.AspNetCore.Identity;

namespace Project_Karel_Gortz.Models.Users
{
    public class CustomUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }
    }
}
