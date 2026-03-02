using DIT.MVC.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace DIT.MVC.Areas.Identity.Models
{
    public class IdentityUserModel
    {
        public DITUser User { get; set; } = null!;
        public List<string> UserRoles { get; set; } = new List<string> { };
        public List<IdentityRole> AvailableRoles { get; set; } = null!;
    }
}
